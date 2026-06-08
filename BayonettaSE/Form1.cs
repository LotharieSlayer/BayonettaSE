using PS3FileSystem;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BayonettaSE
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The target filename, typically inside a ps3 save folder there is usually one file of
        /// particular interest the rest are background noise.
        /// </summary>
        private const string FileName = "CNTDAT";

        /// <summary>This is the PS3 savedata encryption key for this game.</summary>
        private readonly byte[] _key =
        {
0x10, 0x20, 0x30, 0x40, 0x50, 0x60, 0xAA, 0xCC, 0xAA, 0x55, 0x12, 0x0C, 0x0A, 0x04, 0x02, 0x01
        };

        /// <summary>
        /// We store savedata in a byte array for easy manipulation. You could just edit the file
        /// directly if you really wanted. That is considered bad form however due to the overhead of getting the disk IO involved.
        /// </summary>
        private byte[] _buffer;

        /// <summary>Keeps track of the path for the savedata so we can save over it later.</summary>
        private string _filepath, _file;

        //An instance of the savemanager so we can use it for the ps3 version.
        private Ps3SaveManager _manager;

        /// <summary>
        /// True if this is an encrypted PS3 save that needs ReBuildChanges.
        /// False for raw/decrypted saves (emulator, externally decrypted, Wii U).
        /// </summary>
        private bool _PS3_and_Encrypted;

        public Form1()
        {
            InitializeComponent();
            //Comboboxes should be initialised fully as well to ensure they have contents, they misbehave otherwise.
            difficultybox.SelectedIndex = 0;
        }

        /// <summary>
        /// This is a helper function to write a little-endian int32 to a byte array at a given offset. It is reasonably efficient.
        /// </summary>
        /// <param name="buffer">Target byte array</param>
        /// <param name="offset">Beginning offset in array</param>
        /// <param name="value">The value to be written</param>
        private static void WriteInt32LittleEndian(byte[] buffer, int offset, int value)
        {
            buffer[offset + 0] = (byte)(value >> 0);
            buffer[offset + 1] = (byte)(value >> 8);
            buffer[offset + 2] = (byte)(value >> 16);
            buffer[offset + 3] = (byte)(value >> 24);
        }

        private void DecryptedOpen(object sender, EventArgs e)
        {
            using (var o = new OpenFileDialog { Filter = $"{FileName}|{FileName}", Title = "Select Bayonetta Continue Data Save File" })
            {
                if (o.ShowDialog() != DialogResult.OK) return;
                _file = o.FileName;
                _buffer = File.ReadAllBytes(_file);
                _PS3_and_Encrypted = false;
                Read();
            }
        }

        private void MaxHalos(object sender, EventArgs e)
        {   //It is uncertain if the halos are considered uint or int in game but this is more than sufficient.
            halobox.Value = int.MaxValue;
        }


        private void PS3Open(object sender, EventArgs e)
        {
            //PS3 save manipulation typically requires the entire save folder, even if we only want one file from it.
            using (var o = new FolderBrowserDialog { Description = "Navigate to Bayonetta '-CNT' Continue Data PS3 Save Folder" })
            {
                //ShowDialog returns a dialogresult depending on what happens to the dialog, if the user didn't press ok you can be sure a file hasn't been chosen.
                if (o.ShowDialog() != DialogResult.OK) return;
                _filepath = o.SelectedPath;
                _manager = new Ps3SaveManager(_filepath, _key);
                //Check for telltale sign of decryption via pfdtool or any files with broken hashes, sign of decryption or unfixed tampering.
                if (Directory.GetFiles(_filepath).Any(i => i.Contains("~files_decrypted_by_pfdtool")) ||
                    _manager.Files.Any(i => i.IsEncrypted == false))
                {
                    _PS3_and_Encrypted = false;
                    _file = _filepath + @"\" + FileName;
                    _buffer = File.ReadAllBytes(_file);
                }
                else
                {
                    var files = _manager.Files.FirstOrDefault(t => t.PFDEntry.file_name == FileName);
                    if (files != null)
                    {
                        _buffer = files.DecryptToBytes();
                        _file = files.FilePath;
                        _PS3_and_Encrypted = true;
                    }
                    else
                    {
                        MessageBox.Show("Could not find " + FileName + " in the PS3 save folder.");
                        return;
                    }
                }
            }

            Read();
        }

        /// <summary>
        /// We read the values we are interested in from the _buffer using the offsets we know from research.
        /// </summary>
        private void Read()
        {
            //Difficulty @ 0x33
            difficultybox.SelectedIndex = _buffer[0x33];
            //Halos @ 0x0000EF44
            //Note that BitConverter.ToInt32 will read exactly 4 bytes from the starting offset (0x0000EF44).
            //Because I am uncertain if the game regards them as uint or int I read as uint and clamp to int max if needed, this avoids negative values.
            //By clamping it like this we can support the full uint range without issues even though we only intend to use the positive int range.
            uint rawHalos = BitConverter.ToUInt32(_buffer, 0x0000EF44);
            halobox.Value = (rawHalos > int.MaxValue) ? int.MaxValue : (int)rawHalos;
        }

        private void Save(object sender, EventArgs e)
        {
            //Difficulty @ 0x33
            _buffer[0x33] = (byte)difficultybox.SelectedIndex;

            //Halo @ 0x0000EF44
            WriteInt32LittleEndian(_buffer, 0x0000EF44, (int)halobox.Value);

            //Write Items @ 0x0000EF5A
            if (concheckbox.Checked)
            {
                //The starting offset for the items is 0x0000EF5A and each item is 4 bytes long, there are 16 items total.
                int offset = 0x0000EF5A;
                for (var i = 0; i < 16; i++)
                {
                    //Each item is set to 9999
                    WriteInt32LittleEndian(_buffer, offset, 9999);
                    //Advance offset by 4 for next item. Because int32 = 4 bytes.
                    offset += 4;
                }
            }

            //Bayonetta's checksum is located at 0x14 and is 4 bytes.
            //The checksum spans from 0x18 -> EOF
            //New checksum variable.
            int NewChecksum = 0;
            //Compute checksum @ 0x14 by XORing all int32 values from 0x18 to EOF.
            int Position = 0x18;
            do
            {
                //XOR: read 4 bytes to make an int32 and XOR it to checksum. Bitconverter reads 4 bytes because int32 = 4 bytes.
                NewChecksum ^= BitConverter.ToInt32(_buffer, Position);
                //Move to next 4 bytes.
                Position += 4;
            } while (Position < _buffer.Length);

            //Write new checksum to buffer.
            WriteInt32LittleEndian(_buffer, 0x14, NewChecksum);

            //Write edited buffer to file.
            File.WriteAllBytes(_file, _buffer);
            if (_PS3_and_Encrypted)
                _manager.ReBuildChanges(true);
            //Let the user know it worked, tell them the checksum for no reason just because you can.
            MessageBox.Show("Saving Complete.\nNew Checksum: 0x" + NewChecksum.ToString("X8"));
        }
    }
}
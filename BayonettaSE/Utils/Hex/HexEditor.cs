using System;
using System.Collections.Generic;
using System.Linq;

namespace BayonettaSE.Utils.Hex
{
    public class HexEditor
    {
        public static uint ReadAsDecimal(byte[] fileBytes, HexDataInfo info)
        {
            var invertedHex = ReadHexData(fileBytes, info);
            var correctedHex = string.Empty;
            foreach (var hexByte in invertedHex.Reverse())
            {
                correctedHex += string.Format("{0:x2}", hexByte);
            }

            var asDecimal = Convert.ToUInt32(correctedHex, 16);
            return (uint)info.ToHumanReadableValue((int)asDecimal);
        }
        
        public static byte[] ReadHexData(byte[] fileBytes, HexDataInfo info)
        {
            return ReadHexDataAtOffset(fileBytes, info.Offset, info.Size);
        }

        public static byte[] ReadHexDataAtOffset(byte[] fileBytes, int offset, int size)
        {
            return fileBytes.Skip(offset).Take(size).ToArray();
        }
        
        public static void SaveDecimalValue(byte[] fileBytes, HexDataInfo info, int value)
        {
            var correctedDecimal = info.ToSaveFileValue(value);
            var hexString = string.Format("{0:x2}", correctedDecimal);
            var correctedLen = hexString.Length + (hexString.Length % 2);
            hexString = hexString.PadLeft(correctedLen, '0');

            var hexVals = new List<byte>();
            while (hexString.Length > 0)
            {
                var charIndex = Math.Max(hexString.Length - 2, 0);
                var numCharsToRead = Math.Min(2, hexString.Length);
                var singleByteStr = hexString.Substring(charIndex, numCharsToRead);
                var asByte = Convert.ToByte(singleByteStr, 16);
                hexString = hexString.Substring(0, charIndex);
                hexVals.Add(asByte);
            }

            SaveHexData(fileBytes, info, hexVals.ToArray());
        }
        
        public static void SaveHexData(byte[] fileBytes, HexDataInfo info, byte[] bytesToSave)
        {
            SaveHexDataAtOffset(fileBytes, info.Offset, bytesToSave);
        }

        public static void SaveHexDataAtOffset(byte[] fileBytes, int offset, byte[] bytesToSave)
        {
            SaveHexDataAtOffset(fileBytes, offset, bytesToSave);
        }
        
        /// <summary>
        /// This is a helper function to write a little-endian int32 to a byte array at a given offset. It is reasonably efficient.
        /// </summary>
        /// <param name="buffer">Target byte array</param>
        /// <param name="offset">Beginning offset in array</param>
        /// <param name="value">The value to be written</param>
        public static void WriteInt32LittleEndian(byte[] buffer, int offset, int value)
        {
            buffer[offset + 0] = (byte)(value >> 0);
            buffer[offset + 1] = (byte)(value >> 8);
            buffer[offset + 2] = (byte)(value >> 16);
            buffer[offset + 3] = (byte)(value >> 24);
        }
    }
    
    
}
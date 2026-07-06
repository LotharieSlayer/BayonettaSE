namespace BayonettaSE
{
    partial class SaveEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveEditorForm));
            this.button3 = new System.Windows.Forms.Button();
            this.halobox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.concheckbox = new System.Windows.Forms.CheckBox();
            this.difficultybox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pS3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiiUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.halobox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(239, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Lots";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.MaxHalos);
            // 
            // halobox
            // 
            this.halobox.Location = new System.Drawing.Point(71, 38);
            this.halobox.Margin = new System.Windows.Forms.Padding(4);
            this.halobox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.halobox.Name = "halobox";
            this.halobox.Size = new System.Drawing.Size(160, 22);
            this.halobox.TabIndex = 3;
            this.halobox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Halos:";
            // 
            // concheckbox
            // 
            this.concheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.concheckbox.AutoSize = true;
            this.concheckbox.Location = new System.Drawing.Point(16, 111);
            this.concheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.concheckbox.Name = "concheckbox";
            this.concheckbox.Size = new System.Drawing.Size(161, 20);
            this.concheckbox.TabIndex = 5;
            this.concheckbox.Text = "9999 All Consumables";
            this.concheckbox.UseVisualStyleBackColor = true;
            // 
            // difficultybox
            // 
            this.difficultybox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultybox.FormattingEnabled = true;
            this.difficultybox.Items.AddRange(new object[] {
            "Very Easy",
            "Easy",
            "Normal",
            "Hard",
            "Non-Stop Infinite Climax"});
            this.difficultybox.Location = new System.Drawing.Point(71, 75);
            this.difficultybox.Margin = new System.Windows.Forms.Padding(4);
            this.difficultybox.Name = "difficultybox";
            this.difficultybox.Size = new System.Drawing.Size(220, 24);
            this.difficultybox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Difficulty:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pS3ToolStripMenuItem,
            this.wiiUToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // pS3ToolStripMenuItem
            // 
            this.pS3ToolStripMenuItem.Name = "pS3ToolStripMenuItem";
            this.pS3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pS3ToolStripMenuItem.Text = "PS3 (Encrypted)";
            this.pS3ToolStripMenuItem.ToolTipText = "A normal save from a ps3.";
            this.pS3ToolStripMenuItem.Click += new System.EventHandler(this.PS3Open);
            // 
            // wiiUToolStripMenuItem
            // 
            this.wiiUToolStripMenuItem.Name = "wiiUToolStripMenuItem";
            this.wiiUToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wiiUToolStripMenuItem.Text = "Decrypted/Raw";
            this.wiiUToolStripMenuItem.ToolTipText = "Select for PC, Wii U or PS3 emulator saves with no platform-specific encryption due to natural state or save managers handling it.";
            this.wiiUToolStripMenuItem.Click += new System.EventHandler(this.DecryptedOpen);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 135);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.difficultybox);
            this.Controls.Add(this.concheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.halobox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SaveEditorForm";
            this.Text = "Bayonetta Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.halobox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown halobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox concheckbox;
        private System.Windows.Forms.ComboBox difficultybox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pS3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiiUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}


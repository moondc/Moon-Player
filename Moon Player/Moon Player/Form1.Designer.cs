namespace Moon_Player
{
    partial class Form1
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
            this.Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MusicDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBoxFiles = new System.Windows.Forms.ListBox();
            this.ButtonLoadSongs = new System.Windows.Forms.Button();
            this.Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.tabPage1);
            this.Main.Controls.Add(this.tabPage2);
            this.Main.Controls.Add(this.tabPage3);
            this.Main.Location = new System.Drawing.Point(12, 12);
            this.Main.Name = "Main";
            this.Main.SelectedIndex = 0;
            this.Main.Size = new System.Drawing.Size(776, 426);
            this.Main.TabIndex = 0;
            this.Main.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Randomizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonLoadSongs);
            this.tabPage2.Controls.Add(this.ListBoxFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tagging";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MusicDirectoryTextBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Options";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MusicDirectoryTextBox
            // 
            this.MusicDirectoryTextBox.Location = new System.Drawing.Point(90, 3);
            this.MusicDirectoryTextBox.Name = "MusicDirectoryTextBox";
            this.MusicDirectoryTextBox.Size = new System.Drawing.Size(672, 20);
            this.MusicDirectoryTextBox.TabIndex = 1;
            this.MusicDirectoryTextBox.Tag = "";
            this.MusicDirectoryTextBox.WordWrap = false;
            this.MusicDirectoryTextBox.Enter += new System.EventHandler(this.MusicDirectoryTextBox_Enter);
            this.MusicDirectoryTextBox.Leave += new System.EventHandler(this.MusicDirectoryTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Directory";
            // 
            // ListBoxFiles
            // 
            this.ListBoxFiles.FormattingEnabled = true;
            this.ListBoxFiles.HorizontalScrollbar = true;
            this.ListBoxFiles.Location = new System.Drawing.Point(6, 6);
            this.ListBoxFiles.Name = "ListBoxFiles";
            this.ListBoxFiles.Size = new System.Drawing.Size(445, 381);
            this.ListBoxFiles.TabIndex = 0;
            // 
            // ButtonLoadSongs
            // 
            this.ButtonLoadSongs.Location = new System.Drawing.Point(457, 6);
            this.ButtonLoadSongs.Name = "ButtonLoadSongs";
            this.ButtonLoadSongs.Size = new System.Drawing.Size(305, 23);
            this.ButtonLoadSongs.TabIndex = 1;
            this.ButtonLoadSongs.Text = "Load Songs";
            this.ButtonLoadSongs.UseVisualStyleBackColor = true;
            this.ButtonLoadSongs.Click += new System.EventHandler(this.ButtonLoadSongs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Main.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox MusicDirectoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLoadSongs;
        private System.Windows.Forms.ListBox ListBoxFiles;
    }
}


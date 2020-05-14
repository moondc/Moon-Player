using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Moon_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MusicDirectoryTextBox.Text = Properties.Settings.Default.MusicDirectory;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void MusicDirectoryTextBox_Enter(object sender, EventArgs e)
        {
            Properties.Settings.Default.MusicDirectory = MusicDirectoryTextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void MusicDirectoryTextBox_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.MusicDirectory = MusicDirectoryTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void ButtonLoadSongs_Click(object sender, EventArgs e)
        {
            String dir = Properties.Settings.Default.MusicDirectory;
            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Invalid Directory: " + dir);
                return;
            }
            List<string> songlist = new List<string>();
            List<Song> songs = new List<Song>();
            List<string> extensionList = Properties.Settings.Default.Extensions.Split(',').ToList<string>();
            AddSongs(extensionList, songlist, dir);
            
            ConvertToSongName(songs, songlist);
            ListBoxFiles.BeginUpdate();
            foreach(Song song in songs)
            {
                
                ListBoxFiles.Items.Add(song);
            }
            ListBoxFiles.EndUpdate();
        }

        private static void AddSongs(List<string> extensionList,List<string> songlist, string dir)
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                if(extensionList.Contains(new FileInfo(file).Extension.ToLower()))
                {
                    songlist.Add(file);
                }
            }
            foreach(string directory in Directory.GetDirectories(dir))
            {
                AddSongs(extensionList, songlist, directory);
            }
        }
        private static void ConvertToSongName(List<Song> songs, List<string> files)
        {
            foreach(string file in files)
            {
                songs.Add(new Song(file));
            }
        }
    }
}

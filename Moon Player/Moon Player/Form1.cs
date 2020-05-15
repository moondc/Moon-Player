﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

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
            ListBoxFiles.Items.Clear();
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

        private void ListBoxFiles_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Song song = (Song)lb.SelectedItem;
                Clipboard.SetText(song.Display);
                var tfile = TagLib.File.Create(song.Filename);
                TextBoxSongName.Text = tfile.Tag.Title;
                TextBoxAlbum.Text = tfile.Tag.Album;
                TextBoxArtist.Text = tfile.Tag.FirstPerformer;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxSongName_Leave(object sender, EventArgs e)
        {
            try
            {
                Song song = (Song)ListBoxFiles.SelectedItem;
                var tfile = TagLib.File.Create(song.Filename);
                string newTitle = ((TextBox)sender).Text;
                if (newTitle != tfile.Tag.Title)
                {
                    tfile.Tag.Title = ((TextBox)sender).Text;
                    tfile.Save();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxArtist_Leave(object sender, EventArgs e)
        {
            try
            {
                Song song = (Song)ListBoxFiles.SelectedItem;
                var tfile = TagLib.File.Create(song.Filename);
                string newArtist = ((TextBox)sender).Text;
                if (newArtist != tfile.Tag.Title)
                {
                    string[] str = { ((TextBox)sender).Text };
                    tfile.Tag.Performers = str;
                    tfile.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxAlbum_Leave(object sender, EventArgs e)
        {
            try
            {
                Song song = (Song)ListBoxFiles.SelectedItem;
                var tfile = TagLib.File.Create(song.Filename);
                string newAlbum = ((TextBox)sender).Text;
                if (newAlbum != tfile.Tag.Album)
                {
                    tfile.Tag.Album = ((TextBox)sender).Text;
                    tfile.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IncompleteTagButton_Click(object sender, EventArgs e)
        {
            var test = ListBoxFiles.Items;
            List<Song> InvalidSongMetaData = new List<Song>();
            foreach (object obj in test)
            {
                Song song = (Song)obj;
                try
                {
                    var tfile = TagLib.File.Create(song.Filename);

                    String Title = tfile.Tag.Title;
                    String Album = tfile.Tag.Album;
                    String Artist = tfile.Tag.FirstPerformer;
                    if(!(IsValidMetadata(Title) && IsValidMetadata(Album) && IsValidMetadata(Artist)))
                    {
                        song.Display = Title + " " + Album + " " + Artist;
                        InvalidSongMetaData.Add(song);
                    }
                }
                catch (Exception ex)
                {
                    song.Display = ex.Message + " " + song.Filename;
                    InvalidSongMetaData.Add(song);
                }
            }
            ListBoxFiles.BeginUpdate();
            ListBoxFiles.Items.Clear();
            foreach(Song song in InvalidSongMetaData)
            {
                ListBoxFiles.Items.Add(song);
            }
            ListBoxFiles.EndUpdate();
        }

        private bool IsValidMetadata(string str)
        {
            if (str == null) return false;
            if (str == "") return false;
            if (str.Contains("??")) return false;
            return true;
        }
    }
}

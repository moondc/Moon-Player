using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Moon_Player
{
    public class Song
    {
        private Song() { }
        public Song(string filepath)
        {
            Filename = filepath;
            Songname = (new FileInfo(filepath)).Name;
            Display = Path.GetFileNameWithoutExtension(filepath);
        }
        public string Filename { get; private set; }
        public string Songname { get; private set; }
        public string Display
        {
            get { return display; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) { display = Filename; }
                else { display = value; }
            }
        }
        private string display;
        

        public override string ToString()
        {
            return Display;
        }
    }
}

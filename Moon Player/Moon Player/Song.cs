using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Moon_Player
{
    public class Song
    {
        private Song() { }
        public Song(string filepath)
        {
            Filename = filepath;
            Songname = (new FileInfo(filepath)).Name;
        }
        public string Filename { get; private set; }
        public string Songname { get; private set; }

        public override string ToString()
        {
            return Songname;
        }
    }
}

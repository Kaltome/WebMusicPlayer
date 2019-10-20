using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Models
{
    public class Music
    {
        public int no;
        public string name;
        public string title;
        public string artist;
        public string album;
        public string albumImg;
        public string duration;
        public MusicDescription musicDescription;
    }

    public class MusicDescription
    {
        public string title;
        public string description;
    }
}

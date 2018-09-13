using System;
using System.Collections.Generic;
using System.Text;

namespace KillNickleBack
{
    class Song
    {
        // property
        public string Artist { get; set; }
        public string Name { get; set; }

        //  constructor
        public Song (string artist, string name)
        {
            Artist = artist;
            Name = name;
        }
    }
}

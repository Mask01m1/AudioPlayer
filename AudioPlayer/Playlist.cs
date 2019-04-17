using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Playlist
    {
        public string Path;
        public string Title;

        Song[] Songs;

        public Playlist()
        {
            var song1 = new Song();
        }      
    }
}

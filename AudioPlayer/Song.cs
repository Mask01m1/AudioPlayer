using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Song
    {
        public int Duration;
        public string Title;
        public string Path;
        public string Lyries;
        public string Genre;
        public Artist Artist;
        public Album Album;
        public Playlist Playlist;
  

        public Song()
        {
            this.Duration = 196;
            this.Title = "Back in Black";
            this.Genre = "Hard Rock";
        }
        public Song(string title, string genre)
        {
            this.Title = title;
            this.Genre = genre;
        }
    }
}

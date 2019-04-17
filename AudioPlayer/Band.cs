using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Band
    {
        public string Title;
        public string Genre;
        public int Year;
        public bool IsExist;

        public Band()
        {
            this.Title = "ACDC";
            this.Genre = "Hard Rock";
            this.Year = 1973;
            this.IsExist = true;
        }
        public Band(string title, string genre, int year,bool isexist)
        {
            this.Title = title;
            this.Genre = genre;
            this.Year = year;
            this.IsExist = isexist;
        }
    }
}

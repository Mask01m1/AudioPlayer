using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Album
    {
        public string Name;
        public string Path;
        public int Year;
        
        public Album()
        {
            this.Name = "Back in Black";
            this.Year = 1980;
        }
        public Album(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }
    }

}

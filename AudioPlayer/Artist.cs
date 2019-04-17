using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Artist
    {
        public string Name ="ACDC";
        public string Nickname;
        public string Country;
        public Band Band;

        public Artist() { }
        /*{
            this.Name = "Brian Johnson";
            this.Country = "England";
            this.Nickname = "John";
        }  */
        public Artist(string name)
        {
            this.Name = name;
            //this.Country = country;
        }
    }
}

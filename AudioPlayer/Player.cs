using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    class Player
    {
        private const int _maxVolume = 300;
        private int _volume;
        public int Volume
        {
            get
            {
                return _volume;
            }
            private set
            {
                if (value > _maxVolume)
                {
                    _volume = _maxVolume;
                }
                else if (value < 0)
                {
                    _volume = 0;
                }
                else
                {
                    _volume = value;
                }
            }
        }

        bool IsLock;
        public bool Locked;
        /*{
            get
            {
                return Locked;
            }
            private set
            {
                if (value == true)
                {
                    Locked = true;
                }
                else if (value == false)
                {
                    Locked = false;
                }
            }
        }*/
        private bool playing;
        public bool Playing
        {
            get
            {
                return playing;
            }
        }

        public Song[] Songs;

        public void Play()
        {
            for (int i = 0; i < Songs.Length; i++)
            {
                Console.WriteLine(Songs[i].Title + " "+ Songs[i].Artist.Band.Title + " " + Songs[i].Artist.Name +" " + Songs[i].Artist.Country + " " +Songs[i].Duration);
                System.Threading.Thread.Sleep(Songs[i].Duration);
            }
        }

        public void VolumeUp()
        {
            Volume += 5;
            Console.WriteLine("Volume is: " + Volume);
        }

        public void VolumeDown()
        {
            Volume -= 5;
            Console.WriteLine("Volume is: " + Volume);
        }
        public void VolumeChange()
        {
            int step = Convert.ToInt16(Console.ReadLine());
            Volume = step;
            Console.WriteLine("Volume is: " + Volume);
        }
        public void Lock()
        {
            Locked = true;
            Console.WriteLine("Player is Lock");
        }
        public void UnLock()
        {
            Locked = false;
            Console.WriteLine("Player is UnLock");
        }
        public bool Stop()
        {   
            if(Locked != true)
            {
                //Playing = false;
            }
            Console.WriteLine("Player is stoped");
            return Playing;
        }
        public bool Start()
        {   
            if (Locked != true)
            {
                //Playing = true;
            }
            Console.WriteLine("Player is Start");
            return Playing;
        }

    }
}

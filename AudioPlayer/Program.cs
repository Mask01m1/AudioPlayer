using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AudioPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, total = 0;
            var player = new Player();
            Artist a1 = new Artist();

            var songs = CreateSongs(out min, out max, ref total);
            player.Songs = songs;
            Console.WriteLine($"Total duratio: {total}, max duration: {max}, min duration: {min} {a1.Name}");
            while (true)
            {
                switch (ReadLine())
                {
                    case "Up":
                        {
                            player.VolumeUp();
                        }
                        break;

                    case "Down":
                        {
                            player.VolumeDown();
                        }
                        break;
                    case "UpS":
                        {
                            player.VolumeChange();
                        }
                        break;
                    case "P":
                        {
                            player.Play();
                        }
                        break;
                    case "L":
                        {
                            player.Lock();
                        }
                        break;
                    case "U":
                        {
                            player.UnLock();

                        }
                        break;
                    case "S":
                        {
                            player.Stop();
                        }
                        break;

                }
            }
        }
               
        //Player6/10. MethodParameters

        Song CreateDefaultSong()
        {
            var mysongs1 = new Song();
            Random rando = new Random();
            mysongs1.Duration = rando.Next(10);
            int Dyr1 = mysongs1.Duration;

            return mysongs1;
        }

        Song CreateNametSong(string name = "AS")
        {
            Song mysongs2 = new Song();
            Random rando = new Random();
            mysongs2.Title = name;
            mysongs2.Duration = rando.Next(10);
            int Dyr1 = mysongs2.Duration;
            Console.WriteLine(Dyr1);
            return mysongs2;
        }

        private static Song CreateMySong(string name = "AS", string artist = "Bob", string album = "Back in Black", string band = "ACDC")
        {
            Song mysong = new Song();
            var mysongs3 = new Song();
            Random rando = new Random();
            mysongs3.Title = name;
            mysongs3.Artist.Name = artist;
            mysongs3.Album.Name = album;
            mysongs3.Artist.Band.Title = band;
            mysongs3.Duration = rando.Next(10);
            mysong = mysongs3;
            return mysong;
        }

        // end Player6/10. MethodParameters

        private static Song[] CreateSongs(out int min, out int max, ref int total)
        {
            Random rand = new Random();
            Song[] songs = new Song[5];
            int MinDuration = int.MaxValue, MaxDuration = int.MinValue, TotalDuration = 0;
            for (int i = 0; i < songs.Length; i++)
            {
                var song1 = new Song();
                song1.Title = "Song" + i;
                song1.Duration = rand.Next(3001);
                song1.Artist = new Artist();
                song1.Album = new Album();
                song1.Playlist = new Playlist();
                song1.Artist.Band = new Band();
                songs[i] = song1;
                TotalDuration += song1.Duration;
                MinDuration = song1.Duration < MinDuration ? song1.Duration : MinDuration;
                MaxDuration = song1.Duration > MaxDuration ? song1.Duration : MaxDuration;
            }
            total = TotalDuration;
            max = MaxDuration;
            min = MinDuration;
            return songs;
        }
    }
}

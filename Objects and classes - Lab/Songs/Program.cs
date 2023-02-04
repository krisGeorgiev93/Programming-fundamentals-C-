using System;
using System.Collections.Generic;

namespace _3.SOngs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            //{ Song("", name, 1) , Song("",name,1) Song("",name,1) }

            for (int i = 0; i < n; i++)
            {
                string [] currentInput = Console.ReadLine().Split("_"); // favourite_DwonTown_3:14
                string typeList = currentInput[0];
                string name = currentInput[1];
                string time = currentInput[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }
            string list = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Song currentSong = songs[i];
                if (list == "all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (list == currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
        }

        public class Song
        {
            public Song(string typeList, string name, string time) // Constructor
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }

            public string TypeList { get; set; } // Properties
            public string Name { get; set; }
            public string Time { get; set; }


        }


    }
}

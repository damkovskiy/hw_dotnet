using System;
using System.Collections.Generic;
using System.Text;

namespace hm_13
{
    class Song 
    {
        string _name;
        int _duration;
        string _author;
        int _year;
        public enum _genre 
        {
            pop,
            hip_hop,
            metal,
            rock
        };

        public string Name { get { return _name; } set { _name = value; } }
        public int Duration { get { return _duration; } set { _duration = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public int Year { get { return _year; } set { _year = value; } }
               
        public void CreateSong()
        {
            Console.WriteLine("Input name of song");
            Name = Console.ReadLine();
            Console.WriteLine("Input duration of song");
            Duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input author of song");
            Author = Console.ReadLine();
            Console.WriteLine("Input year of song");
            Year = Convert.ToInt32(Console.ReadLine()); 
        }
    }
}

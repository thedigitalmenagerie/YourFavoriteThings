using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.FavoriteThings
{
    class Movies
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public int YearReleased { get; set; }
        public bool HasWatched { get; set; } = false;
        public bool Own { get; set; } = false;


        public Movies(string name, string director, int yearReleased)
        {
            Name = name;
            Director = director;
            YearReleased = yearReleased;
        }

        public void Stream()
        {
            HasWatched = true;
            if(HasWatched == true)
            {
                Console.WriteLine($"You have now watched {Name} via streaming.");
            }
        }

        public void Buy()
        {
            HasWatched = true;
            Own = true;
            if(HasWatched == true && Own == true)
            {
                Console.WriteLine($"You have now acquired {Name} as part of your personal collection.");
            }
        }
    }
}

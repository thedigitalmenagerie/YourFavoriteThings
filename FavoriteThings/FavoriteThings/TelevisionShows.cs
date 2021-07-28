using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.FavoriteThings
{
    class TelevisionShows
    {
        public string Name { get; set; }
        public int NumberOfSeasons { get; set; }
        public string FavoriteCharacter { get; set; } = "";
        public bool HasWatched { get; set; } = false;
        public string ShowRating { get; set; } = "";

        public TelevisionShows(string name, int numberOfSeasons)
        {
            Name = name;
            NumberOfSeasons = numberOfSeasons;
        }

        public void Watch()
        {
            HasWatched = true;
            if(HasWatched == true)
            {
                Console.WriteLine($"You have watched {Name}. Please provide a 1-5 rating:");
                ShowRating = Console.ReadLine();
                Console.WriteLine("You have now rated the show. Please name your favorite character:");
                FavoriteCharacter = Console.ReadLine();
            }
        }

        public void PutOnAsBackgroundNoiseWhileYouWork()
        {
            HasWatched = false;
            if(HasWatched == false)
            {
                Console.WriteLine($"Have you really watched {Name}? Please watch again outside of work hours.");
            }
        }

    }
}

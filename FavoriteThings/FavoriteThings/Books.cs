using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.FavoriteThings
{
    class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ShortSummary { get; set; } = "";
        public bool HasRead { get; set; } = false;

        public string BookRating { get; set; } = "";

        public Books(string name, string author, int publicationYear)
        {
            Name = name;
            Author = author;
            PublicationYear = publicationYear;
        }

        public void Read()
        {
            HasRead = true;
            if(HasRead == true)
            {
                Console.WriteLine($"You have read {Name}. Please summarize:");
                ShortSummary = Console.ReadLine();
            }
        }

        public void RateBook()
        {
            if (HasRead == true)
            {
                Console.WriteLine("Rate the book 1-5");
                BookRating = Console.ReadLine();
            }
        }
    }
}

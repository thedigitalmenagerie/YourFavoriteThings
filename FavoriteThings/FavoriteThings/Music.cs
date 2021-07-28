using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.FavoriteThings
{
    class Music
    {
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public int Year { get; set; }
        public bool Own { get; set; } = false;
        public bool OnPlaylist { get; set; } = false;

        public Music(string artistName, string albumName, int year)
        {
            ArtistName = artistName;
            AlbumName = albumName;
            Year = year;
        }

        public void AddToPlaylist()
        {
            OnPlaylist = true;
            if(OnPlaylist == true)
            {
                Console.WriteLine($"You have added {AlbumName} to your playlist.");
            }
        }

        public void Purchase()
        {
            Own = true;
            if(Own == true)
            {
                Console.WriteLine($"You now own {AlbumName} by {ArtistName}.");
            }
        }

    }
}

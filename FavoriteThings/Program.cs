using System;
using FavoriteThings.FavoriteThings;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var ToSayNothingOfTheDog = new Books("To Say Nothing of the Dog", "Connie Willis", 1997);
            var TheLongTomorrow = new Books("The Long Tomorrow", "Leigh Brackett", 1955);

            ToSayNothingOfTheDog.Read();
            TheLongTomorrow.Read();
            TheLongTomorrow.RateBook();

            var Seinfeld = new TelevisionShows("Seinfeld", 9);
            var ItsAlwaysSunny = new TelevisionShows("It's Always Sunny in Philedelphia", 14);

            Seinfeld.PutOnAsBackgroundNoiseWhileYouWork();
            ItsAlwaysSunny.Watch();

            var AdrienneLenker = new Music("Adrienne Lenker", "songs", 2020);
            var BrianEno = new Music("Brian Eno", "Here Come the Warm Jets", 1973);

            AdrienneLenker.AddToPlaylist();
            BrianEno.Purchase();

            var TheTwentiethCentury = new Movies("The Twentieth Century", "Matthew Rankin", 2019);
            var OneCutOfTheDead = new Movies("One Cut of the Dead", "Shinichiro Ueda", 2017);

            TheTwentiethCentury.Buy();
            OneCutOfTheDead.Stream();

        }
    }
}

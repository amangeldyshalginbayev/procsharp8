using System;

namespace LazyObjectInstantiation
{
    public class AllTracks
    {
        private Song[] _allSongs = new Song[10000];

        public AllTracks()
        {
            // Filling up the array of song objects here
            Console.WriteLine("Filling up the songs by creating 10_000 objects in memory!");
        }

        public AllTracks(int some_init_value)
        {
            // some custom init logic using some_init_value
        }
    }
}
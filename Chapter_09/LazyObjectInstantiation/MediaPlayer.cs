using System;

namespace LazyObjectInstantiation
{
    public class MediaPlayer
    {
        //private AllTracks _allSongs = new AllTracks();
        //private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>();

        private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>(
            () =>
            {
                Console.WriteLine("Creating AllTracks object!");
                return new AllTracks();
            }
            );
        
        public void Play()
        {
            // Play a song
        }

        public void Pause()
        {
            // Pause the song
        }

        public void Stop()
        {
            // Stop playback
        }

        public AllTracks GetAllTracks()
        {
            // Return all of the songs
            return _allSongs.Value;
        }
    }
}
using System;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instantiation *****\n");
            
            // This caller does not care about getting all songs,
            // but indirectly created 10,000 objects!
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();

            MediaPlayer yourPlayer = new MediaPlayer();
            AllTracks yourMusic = yourPlayer.GetAllTracks();

            Console.ReadLine();
        }
    }
}
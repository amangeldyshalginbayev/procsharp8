using System;
using System.Linq;

namespace LinqUsingEnumerable
{
    public class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine("***** Using Raw Delegates *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            Func<string, bool> searchFilter = new Func<string, bool>(Filter);
            Func<string, string> itemToProcessWhenSorting = new Func<string, string>(ProcessItem);

            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcessWhenSorting)
                .Select(itemToProcessWhenSorting);

            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}", game);
            }

            Console.WriteLine();
        }

        private static bool Filter(string game)
        {
            return game.Contains(" ");
        }

        private static string ProcessItem(string game)
        {
            return game;
        }
    }
}
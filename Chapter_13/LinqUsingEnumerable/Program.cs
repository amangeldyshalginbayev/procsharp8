using System;
using System.Linq;

namespace LinqUsingEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //QueryStringWithOperators();
            //QueryStringsWithEnumerableAndLambdas();
            //QueryStringsWithEnumerableAndLambdas2();
            //QueryStringsWithAnonymousMethods();
            VeryComplexQueryExpression.QueryStringsWithRawDelegates();
        }

        private static void QueryStringWithOperators()
        {
            Console.WriteLine("***** Using Query Operators *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            var subset = from game in currentVideoGames
                where game.Contains(" ")
                orderby game
                select game;

            foreach (var s in subset)
            {
                Console.WriteLine("Item: {0}", s);
            }
        }

        private static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            var subset = currentVideoGames.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);

            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}", game);
            }

            Console.WriteLine();
        }

        private static void QueryStringsWithEnumerableAndLambdas2()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions 2 *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            var gamesWithSpaces = currentVideoGames.Where(g => g.Contains(" "));
            var orderedGames = gamesWithSpaces.OrderBy(g => g);
            var subset = orderedGames.Select(g => g);

            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}", game);
            }

            Console.WriteLine();
        }

        private static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("***** Using Anonymous Methods *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            Func<string, bool> searchFilter = delegate(string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate(string game) { return game; };

            var subset = currentVideoGames.Where(searchFilter).OrderBy(itemToProcess).Select(itemToProcess);

            foreach (var game in subset)
            {
                Console.WriteLine("Item: {0}", game);
            }

            Console.WriteLine();
        }
    }
}
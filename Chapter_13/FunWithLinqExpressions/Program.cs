using System;
using System.Collections.Generic;
using System.Linq;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");

            ProductInfo[] itemsInStock = new[]
            {
                new ProductInfo {Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
                new ProductInfo {Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
                new ProductInfo {Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
                new ProductInfo {Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
                new ProductInfo {Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
                new ProductInfo {Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
            };

            //SelectEverything(itemsInStock);
            //ListProductNames(itemsInStock);
            //GetOverStock(itemsInStock);
            //GetNamesAndDescriptions(itemsInStock);
            // Array objs = GetProjectedSubset(itemsInStock);
            // foreach (var product in objs)
            // {
            //     Console.WriteLine(product);
            // }
            //GetNamesAndDescriptionsTyped(itemsInStock);
            //GetCountFromQuery();
            //ReverseEverything(itemsInStock);
            //AplhabetizeProductNames(itemsInStock);
            //DisplayDiff();
            //DisplayIntersection();
            //DisplayUnion();
            //DisplayConcat();
            //DisplayConcatNoDups();
            AggregateOps();
            

            Console.ReadLine();
        }

        private static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("All product details:");
            var allProducts = from p in products select p;

            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        private static void ListProductNames(ProductInfo[] products)
        {
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;

            foreach (var name in names)
            {
                Console.WriteLine("Name: {0}", name);
            }
        }

        private static void GetOverStock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items!");

            var overstock = from p in products where p.NumberInStock > 25 select p;

            foreach (var productInfo in overstock)
            {
                Console.WriteLine(productInfo.ToString());
            }
        }

        private static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var nameDesc = from p in products select new {p.Name, p.Description};

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }

        // Cant use var as return type
        // private static var GetProjectedSubset(ProductInfo[] products)
        // {
        //     
        // }

        private static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new {p.Name, p.Description};

            return nameDesc.ToArray();
        }

        private static void GetNamesAndDescriptionsTyped(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");

            IEnumerable<ProductInfoSmall> nameDesc = from p in products
                select new ProductInfoSmall {Name = p.Name, Description = p.Description};

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void GetCountFromQuery()
        {
            string[] currentVideoGames = {"Moroowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();

            Console.WriteLine("{0} items honor the LINQ query.", numb);
        }

        private static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Products in reverse:");
            var allProducts = from p in products select p;

            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }

        private static void AplhabetizeProductNames(ProductInfo[] products)
        {
            var subset = from p in products orderby p.Name select p;

            Console.WriteLine("Ordered by Name:");

            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        private static void DisplayDiff()
        {
            List<string> myCars = new List<string>() {"Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() {"BMW", "Saab", "Aztec"};

            var carDiff = (from c in myCars select c)
                .Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you don't have, but I do:");
            foreach (var s in carDiff)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplayIntersection()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec"};

            var intersect = (from c in myCars select c)
                .Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here is what we have in common:");
            foreach (var s in intersect)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplayUnion()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() { "BMW", "Saab", "Aztec"};

            var carUnion = (from c in myCars select c)
                .Union(from c2 in yourCars select c2);

            foreach (var s in carUnion)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplayConcat()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() {"BMW", "Saab", "Aztec"};

            var carConcat = (from c in myCars select c)
                .Concat(from c2 in yourCars select c2);

            Console.WriteLine("Concatenation: ");
            foreach (var s in carConcat)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<string>() { "Yugo", "Aztec", "BMW"};
            List<string> yourCars = new List<string>() {"BMW", "Saab", "Aztec"};

            var carConcat = (from c in myCars select c)
                .Concat(from c2 in yourCars select c2);

            Console.WriteLine($"Type of carConcat: [{carConcat.GetType()}]");

            foreach (var s in carConcat.Distinct())
            {
                Console.WriteLine(s);
            }
        }

        private static void AggregateOps()
        {
            double[] winterTemps = {2.0, -21.3, 8, -4, 0, 8.2};

            Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());
            Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());
            Console.WriteLine("Average temp: {0}", (from t in winterTemps select t).Average());
            Console.WriteLine("Sum of all temps: {0}", (from t in winterTemps select t).Sum());
        }
    }
}
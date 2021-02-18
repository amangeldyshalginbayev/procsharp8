using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("***** Fun With Async ===> *****");
            //string message = await DoWorkAsync();
            // await MultipleAwaits();
            // Console.WriteLine("Work completed!");
            // Console.ReadLine();

            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }

        static string DoWork()
        {
            Thread.Sleep(7_000);
            return "Done with work!";
        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(7_000);
                return "Done with work!";
            });
        }

        static async Task MultipleAwaits()
        {
            // await Task.Run(() => { Thread.Sleep(2_000); });
            // Console.WriteLine("Done with first task!");
            //
            // await Task.Run(() => { Thread.Sleep(2_000); });
            // Console.WriteLine("Done with second task!");
            //
            // await Task.Run(() => { Thread.Sleep(2_000); });
            // Console.WriteLine("Done with third task!");

            var task1 = Task.Run(() =>
            {
                Thread.Sleep(8_000);
                Console.WriteLine("Done with first task!");
            });


            var task2 = Task.Run(() =>
            {
                Thread.Sleep(4_000);
                Console.WriteLine("Done with second task!");
            });


            var task3 = Task.Run(() =>
            {
                Thread.Sleep(2_000);
                Console.WriteLine("Done with third task!");
            });
            
            //await Task.WhenAll(task1, task2, task3); // returns when all tasks completed
            await Task.WhenAny(task1, task2, task3); // returns when any task completed
        }

        static async ValueTask<int> ReturnAnInt()
        {
            await Task.Delay(3_000);
            return 5;
        }

        static async Task MethodWithProblems(int firstParam, int secondParam)
        {
            Console.WriteLine("Enter");
            await Task.Run(() =>
            {
                // Call long running method
                Thread.Sleep(5_000);
                Console.WriteLine("First Complete");
                // Call another long running method that fails because
                // the second parameter is out of range
                Console.WriteLine("Something bad happened");
            });
        }

        static async Task MethodWithProblemsFixed(int firstParam, int secondParam)
        {
            Console.WriteLine("Enter");
            if (secondParam < 0)
            {
                Console.WriteLine("Bad data");
                return;
            }

            await actualImplementation();

            async Task actualImplementation()
            {
                await Task.Run(() =>
                {
                    // Call long running method
                    Thread.Sleep(5_000);
                    Console.WriteLine("First Complete");
                    // Call another long running method that fails because
                    // the second parameter is out of range
                    Console.WriteLine("Something bad happened");
                });
            }
        }
        
        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }
}
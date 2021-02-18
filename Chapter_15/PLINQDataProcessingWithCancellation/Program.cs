using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PLINQDataProcessingWithCancellation
{
    class Program
    {
        static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Press any key to start processing");
                Console.ReadKey();
                Console.WriteLine("Processing");
                Task.Factory.StartNew(ProcessIntDataInParallel);
                Console.Write("Enter Q to quit: ");
                string answer = Console.ReadLine();
                // Does user want to quit?
                if (answer.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    _cancellationTokenSource.Cancel();
                    break;
                }
            } while (true);

            Console.ReadLine();
        }

        static void ProcessIntData()
        {
            int[] source = Enumerable.Range(1, 150_000_000).ToArray();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] modThreeIsZero = (
                from num in source
                where num % 3 == 0
                orderby num descending
                select num).ToArray();
            stopwatch.Stop();
            Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");
            Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
        }

        static void ProcessIntDataInParallel()
        {
            int[] source = Enumerable.Range(1, 150_000_000).ToArray();
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                int[] modThreeIsZero = (
                    from num in source.AsParallel().WithCancellation(_cancellationTokenSource.Token)
                    where num % 3 == 0
                    orderby num descending
                    select num).ToArray();
                stopwatch.Stop();
                Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");
                Console.WriteLine($"Found {modThreeIsZero.Count()} numbers that match query!");
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
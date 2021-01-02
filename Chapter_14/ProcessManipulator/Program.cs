using System;
using System.Linq;
using System.Diagnostics;

namespace ProcessManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Processes *****\n");
            //ListAllRunningProcesses();
            //GetSpecificProcess();
            //EnumThreadsForPid(41448);

            // Console.WriteLine("***** Enter PID of process to investigate *****");
            // Console.Write("PID: ");
            // string pID = Console.ReadLine();
            // int theProcID = int.Parse(pID);
            
            //EnumThreadsForPid(theProcID);
            //EnumModsForPid(theProcID);
            
            //StartAndKillProcess();
            UseApplicationVerbs();

            Console.ReadLine();
        }

        private static void ListAllRunningProcesses()
        {
            var runningProcs = from proc in Process.GetProcesses(".")
                orderby proc.Id
                select proc;

            foreach (var p in runningProcs)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }

            Console.WriteLine("********************\n");
        }

        private static void GetSpecificProcess()
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(41448);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void EnumThreadsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
            ProcessThreadCollection theThreads = theProc.Threads;

            foreach (ProcessThread pt in theThreads)
            {
                string info =
                    $"Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority:{pt.PriorityLevel}";
                Console.WriteLine(info);
            }

            Console.WriteLine("*****************************\n");
        }

        private static void EnumModsForPid(int pID)
        {
            Process theProc = null;
            try
            {
                theProc = Process.GetProcessById(pID);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Here are the loaded modules for: {0}", theProc.ProcessName);
            ProcessModuleCollection theMods = theProc.Modules;
            foreach (ProcessModule pm in theMods)
            {
                string info = $"-> Mod Name: {pm.ModuleName}";
                Console.WriteLine(info);
            }

            Console.WriteLine("****************************\n");
        }

        private static void StartAndKillProcess()
        {
            Process ffProc = null;

            try
            {
                ffProc = Process.Start(@"/Applications/Google Chrome.app/Contents/MacOS/Google Chrome","www.facebook.com");

                ProcessStartInfo startInfo =
                    new ProcessStartInfo(@"/Applications/Google Chrome.app/Contents/MacOS/Google Chrome", "www.github.com/amangeldyshalginbayev");
                startInfo.UseShellExecute = true;
                ffProc = Process.Start(startInfo);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("--> Hit enter to kill {0}...", ffProc.ProcessName);
            Console.ReadLine();

            try
            {
                foreach (var p in Process.GetProcessesByName("Google Chrome"))
                {
                    p.Kill(true);
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void UseApplicationVerbs()
        {
            int i = 0;
            ProcessStartInfo si = new ProcessStartInfo(@"/Applications/Microsoft Word.app/Contents/MacOS/Microsoft Word");
            foreach (var verb in si.Verbs)
            {
                Console.WriteLine($" {i++}. {verb}");
            }

            si.WindowStyle = ProcessWindowStyle.Maximized;
            si.Verb = "Edit";
            si.UseShellExecute = true;

            try
            {
                Process.Start(si);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
using System;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Runtime.Loader;

namespace DefaultAppDomainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with the default AppDomain *****");
            
            //DisplayDADStats();
            //ListAllAssembliesInAppDomain();
            //LoadAdditionalAssembliesDifferentContexts();
            LoadAdditionalAssembliesSameContext();
        }

        private static void DisplayDADStats()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            Console.WriteLine("Name of this domain: {0}", defaultAD.FriendlyName);
            Console.WriteLine("ID of domain in this process: {0}", defaultAD.Id);
            Console.WriteLine("Is this the default domain?: {0}", defaultAD.IsDefaultAppDomain());
            Console.WriteLine("Base directory of this domain: {0}", defaultAD.BaseDirectory);
            Console.WriteLine("Setup Information for this domain:");
            Console.WriteLine("\t Application Base: {0}", defaultAD.SetupInformation.ApplicationBase);
            Console.WriteLine("\t Target Framework: {0}", defaultAD.SetupInformation.TargetFrameworkName);
        }

        private static void ListAllAssembliesInAppDomain()
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;

            var loadedAssemblies = defaultAD.GetAssemblies().OrderBy(x => x.GetName().Name);
            Console.WriteLine("***** Here are the assemblies loaded in {0} *****\n", defaultAD.FriendlyName);
            foreach (var a in loadedAssemblies)
            {
                Console.WriteLine($"-> Name, Version: {a.GetName().Name}:{a.GetName().Version}");
            }
        }

        private static void LoadAdditionalAssembliesDifferentContexts()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLibrary1.dll");
            AssemblyLoadContext lc1 = new AssemblyLoadContext("NewContext1", false);

            var cl1 = lc1.LoadFromAssemblyPath(path);
            var c1 = cl1.CreateInstance("ClassLibrary1.Car");

            AssemblyLoadContext lc2 = new AssemblyLoadContext("NewContext2", false);
            var cl2 = lc2.LoadFromAssemblyPath(path);
            var c2 = cl2.CreateInstance("ClassLibrary1.Car");
            Console.WriteLine("***** Loading Additional Assemblies in Different Contexts *****");
            Console.WriteLine($"Assembly1.Equals(Assembly2) : {cl1.Equals(cl2)}");
            Console.WriteLine($"Assembly1 == Assembly2 : {cl1 == cl2}");
            Console.WriteLine($"Class1.Equals(Class2) : {c1.Equals(c2)}");
            Console.WriteLine($"Class1 == Class2 {c1 == c2}");
            Console.WriteLine("Type names are below:");
            Console.WriteLine(c1.GetType().Assembly.FullName);
            Console.WriteLine(c2.GetType().Assembly.FullName);
        }

        private static void LoadAdditionalAssembliesSameContext()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ClassLibrary1.dll");

            AssemblyLoadContext lc1 = new AssemblyLoadContext(null, false);

            var cl1 = lc1.LoadFromAssemblyPath(path);
            var c1 = cl1.CreateInstance("ClassLibrary1.Car");
            var cl2 = lc1.LoadFromAssemblyPath(path);
            var c2 = cl2.CreateInstance("ClassLibrary1.Car");
            Console.WriteLine("***** Loading Additional Assemblies in the same context *****");
            Console.WriteLine($"Assembly1.Equals(Assembly2) : {cl1.Equals(cl2)}");
            Console.WriteLine($"Assembly1 == Assembly2 : {cl1 == cl2}");
            Console.WriteLine($"Class1.Equals(Class2) : {c1.Equals(c2)}");
            Console.WriteLine($"Class1 == Class2 : {c1 == c2}");
        }
    }
}
using System;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interface Name Clashes *****\n");

            Octagon oct = new Octagon();
            
            

            IDrawToForm itdForm = (IDrawToForm) oct;
            itdForm.Draw();
            
            ((IDrawToPrinter)oct).Draw();

            if (oct is IDrawToMemory dtm)
            {
                dtm.Draw();
            }
            
            Console.WriteLine("stop point");
            Console.ReadLine();
        }
    }
}
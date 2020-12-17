using System;

namespace InterfaceNameClash
{
    public class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        // public void Draw()
        // {
        //     Console.WriteLine("Drawing the Octagon...");
        // }

        // Explicit interface implementation examples
        // implemented methods via explicit interface implementation
        // are private, not available via object, need to cast
        // to the relevant interface type to call these methods
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to a printer...");
        }
    }
}
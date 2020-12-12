using System;

namespace Shapes
{
    public abstract class Shape
    {
        public string PetName { get; set; }
        
        protected Shape(string name = "NoName")
        {
            Console.WriteLine("Inside Shape constr");
            PetName = name;
        }

        // protected Shape()
        // {
        //     Console.WriteLine("Inside Shape empty constr");
        // }

        public abstract void Draw();
        // {
        //     Console.WriteLine("Inside Shape.Draw()");
        // }
    }

}
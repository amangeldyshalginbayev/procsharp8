using System;

namespace CustomInterfaces
{
    public class Triangle : Shape, IPointy
    {
        public Triangle()
        {
            
        }

        public Triangle(string name) : base(name)
        {
            
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }

        public byte Points => 3;
    }
}
using System;

namespace Shapes
{
    public class ThreeDCircle : Circle
    {
        public new string PetName { get; set; }
        
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }

        public ThreeDCircle()
        {
            Console.WriteLine("Inside ThreeDCircle constr");
        }
    }
}
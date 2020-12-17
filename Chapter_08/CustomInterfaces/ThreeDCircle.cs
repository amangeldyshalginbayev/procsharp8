using System;

namespace CustomInterfaces
{
    public class ThreeDCircle : Circle, IDraw3D
    {
        public new string PetName { get; set; }
        
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }

        public ThreeDCircle()
        {
            Console.WriteLine("Inside ThreeDCircle empty constr");
        }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
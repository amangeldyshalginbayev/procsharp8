using System;
using MyShapes;
using My3DShapes;

// resolving ambiguity with custom alias
using The3DHexagon = My3DShapes.Hexagon;
using bfHome = System.Runtime.Serialization.Formatters.Binary;

namespace CustomNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyShapes.Hexagon h = new MyShapes.Hexagon();
            // MyShapes.Circle c = new MyShapes.Circle();
            // MyShapes.Square s = new MyShapes.Square();
            
            // Hexagon h = new Hexagon();
            // Circle c = new Circle();
            // Square s = new Square();

            // The3DHexagon h2 = new My3DShapes.Hexagon();
            // The3DHexagon h3 = new The3DHexagon();

            bfHome.BinaryFormatter b = new bfHome.BinaryFormatter();
        }
    }
}
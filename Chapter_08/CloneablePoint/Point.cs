using System;

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();

        public Point()
        {
            
        }

        public Point(int x, int y, string petName)
        {
            X = x;
            Y = y;
            desc.PetName = petName;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";
        }

        public object Clone()
        {
            //return new Point(this.X, this.Y);

            // copy each field of the Point member by member
            //return this.MemberwiseClone();

            Point newPoint = (Point) this.MemberwiseClone();

            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }
}
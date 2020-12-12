using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun eith System.Object *****/n");
            // Person p1 = new Person();
            //
            // Console.WriteLine("ToString: {0}",p1.ToString());
            // Console.WriteLine("Hash code: {0}",p1.GetHashCode());
            // Console.WriteLine("Type: {0}", p1.GetType());
            //
            // Person p2 = p1;
            // object o = p2;
            //
            // if (o.Equals(p1) && p2.Equals(o))
            // {
            //     Console.WriteLine("Same instance1");
            // }
            
            Person p1 = new Person("Homer", "Simpson",50,"111-11-1111");
            Person p2 = new Person("Homer","Simpson",50,"111-11-1111");

            Console.WriteLine("p1.ToString() = {0}",p1.ToString());
            Console.WriteLine("p2.ToString() = {0}",p2.ToString());

            Console.WriteLine("p1 == p2 ?: {0}",p1.Equals(p2));

            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();

            p2.Age = 45;
            Console.WriteLine("p1.ToString() = {0}",p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            Console.WriteLine("p1 == p2 ? : {0}",p1.Equals(p2));

            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

            Console.WriteLine("Static methods from System.Object()");
            Person p3 = new Person("Sally","Jones",4);
            Person p4 = new Person("Sally","Jones",4);
            Console.WriteLine("P3 and P4 have the same state: {0}", object.Equals(p3,p4));
            Console.WriteLine("P3 and P4 are pointing to the same object: {0}",object.ReferenceEquals(p3,p4));
            
            Console.ReadLine();
        }
    }
}
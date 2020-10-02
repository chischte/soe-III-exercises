using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Compound("C1");
            c1.Add(new Circle("K1"));

            var c2 = new Compound("C2");
            c2.Add(new Rectangle("R21"));
            c2.Add(new Circle("K21"));
            c1.Add(c2);
            c1.Add(new Circle("K2"));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Drawing... (dynamic binding)");
            Console.WriteLine("-------------------------------------------");
            c1.Draw();

            Console.ReadKey();
        }
    }
}

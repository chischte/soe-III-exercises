using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Erzeuge Square-Objekt
            var s = new Square(1, 2, 4);

            // TODO: Ausgabe Degrees
            Console.WriteLine("Degress : {0}", s.Degrees);

            // TODO: Ausgabe Area()
            Console.WriteLine("Area : {0}", s.Area());

            // TODO: Ausgabe X1, Y1, X2, Y2
            Console.WriteLine("(X1, Y1):({0},{1}) (X2, Y2):({2},{3})", s.X1, s.Y1, s.X2, s.Y2);

            Console.ReadKey();
        }
    }
}

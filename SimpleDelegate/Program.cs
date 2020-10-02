using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegate
{
  public delegate double CalculateHandler(double value1, double value2);

    class Program
    {
      static void Main(string[] args)
      {
        // Variable vom Typ des Delegaten
        CalculateHandler calculate;
        do
        {
          // Eingabe der Operanden
          Console.Clear();
          Console.Write("Geben Sie den ersten Operanden ein: ");
          double input1 = Convert.ToDouble(Console.ReadLine());
          Console.Write("Geben Sie den zweiten Operanden ein: ");
          double input2 = Convert.ToDouble(Console.ReadLine());
          // Wahl der Operation
          Console.Write("Operation: Addition - (A) oeder Subtraktion - (S)? ");
          string wahl = Console.ReadLine().ToUpper();
          // in Abhängigkeit von der Wahl des Anwenders wird die Variable 
          // 'calculate' mit einem Zeiger auf die auszuführende Methode 
          // initialisiert
          if (wahl == "A")
            calculate = new CalculateHandler(Demo.Add);
          else if (wahl == "S")
            calculate = new CalculateHandler(Demo.Subtract);
          else
          {
            Console.Write("Ungültige Eingabe");
            Console.ReadLine();
            return;
          }
          // Aufruf der Operation 'Addition' oder 'Subtraktion' über den Delegaten
          double result = calculate(input1, input2);
          Console.WriteLine("----------------------------------");
          Console.WriteLine("Ergebnis = {0}\n\n", result);
          Console.WriteLine("Zum Beenden F12 drücken.");
        } while (Console.ReadKey(true).Key != ConsoleKey.F12);
      }  
    }
  
    class Demo
    {
      public static double Add(double x, double y)
      {
        return x + y;
      }
      public static double Subtract(double x, double y)
      {
        return x - y;
      }
    }
}

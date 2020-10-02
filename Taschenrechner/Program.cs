using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            SealedTest2.Test();
            Console.ReadLine();

            //while (true) 
            //{
            //    Screen();

            //    string inputString = Console.ReadLine();

            //    if (Int32.TryParse(inputString, out int option) && (option == 1 || option == 2))
            //    {
            //        try
            //        {
            //            Console.Write("Eingabe 1: ");
            //            var input1 = Console.ReadLine();
            //            var zahl1 = Convert.ToDouble(input1);
            //            Console.Write("Eingabe 2: ");
            //            var input2 = Console.ReadLine();
            //            var zahl2 = Convert.ToDouble(input2);

            //            switch (option)
            //            {
            //                case 1:
            //                    var sum = zahl1 + zahl2;
            //                    Console.WriteLine("Das Resultat ist:  {0:X}",
            //                        Math.Round(sum, 2).ToString(CultureInfo.InvariantCulture));
            //                    Console.WriteLine("-------------Drücke auf Enter--------------");
            //                    Console.ReadLine();
            //                    break;
            //                case 2:
            //                    var diff = zahl1 - zahl2;
            //                    Console.WriteLine("Das Resultat ist:  {0:X}",
            //                        Math.Round(diff, 2).ToString(CultureInfo.InvariantCulture));
            //                    Console.WriteLine("-------------Drücke auf Enter--------------");
            //                    Console.ReadLine();
            //                    break;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Ungültige Eingabe, versuche nochmals!" + ex.Message);
            //            Console.WriteLine("-------------Drücke auf Enter--------------");
            //            Console.ReadLine();
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Bitte wähle eine Option von oben aus");
            //        Console.WriteLine("-------------Drücke auf Enter--------------");
            //        Console.ReadLine();
            //    }
            //}
        }

        private static void Screen()
        {
            Console.Clear();
            Console.WriteLine("Taschenrechner");
            Console.WriteLine("--------------");
            Console.WriteLine("Optionen");
            Console.WriteLine("--------------");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("--------------");
            Console.Write("Option-Eingabe: ");
        }
    }

    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    static class SealedTest2
    {
        public static void Test()
        {
            var sc = new SealedClass();
            sc.x = 110;
            sc.y = 150;
            Console.WriteLine($"x = {sc.x}, y = {sc.y}");
        }
    }
}

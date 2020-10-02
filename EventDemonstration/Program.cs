using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemonstration
{
    public delegate string DemoDelegate(string str1, string str2);

    class MyEvents
    {
        public event DemoDelegate MyEvent;

        public MyEvents()
        {
            this.MyEvent += new DemoDelegate(this.Display);
        }

        public string Display(string studentName, string subject)
        {
            return "Student: " + studentName + "\nSubject: " + subject;
        }

        static void Main(string[] args)
        {
            var e = new MyEvents();
            string res = e.MyEvent("Meier", "Informatik");
            Console.WriteLine("RESULT...\n" + res);

            Console.ReadKey();
        }
    }
}

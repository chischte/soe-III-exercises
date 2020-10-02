using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MulticastDelegateSample1
{
  public delegate void MyDelegate();

  class Program
  {
      static void Main(string[] args)
      {
          //MyDelegate del = (MyDelegate)Delegate.Combine(new MyDelegate(DoSomething), new MyDelegate(DoSomethingMore));
          // Multicast-Delegaten ausführen
          //del();

          //TODO
          var delSomething = (MyDelegate) MethodeClass.DoSomething;
          var delSomethingMore = (MyDelegate)MethodeClass.DoSomethingMore;

          delSomething();
          delSomethingMore();

          Console.ReadLine();
      }
  }
  static class MethodeClass
  {
      public static void DoSomething()
      {
          Console.WriteLine("In der Methode 'DoSomething'");
      }

      public static void DoSomethingMore()
      {
          Console.WriteLine("In der Methode 'DoSomethingMore'");
      }
    }
}

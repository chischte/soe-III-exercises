using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace CopyObject
{
    [Serializable]
    class TestObject
    {
        public String Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestObject FirstObject = new TestObject();
            FirstObject.Name = "Original";

            TestObject SecondObject = new TestObject();
            SecondObject.Name = "Copy";

            // Copy Original to copy makes only a reference !!!
            //SecondObject = FirstObject;

            // This is how to make a deep copy !!!
            SecondObject = DeepClone(FirstObject);

            // Proof that the Objects are stored on a different location:
            GetMemoryAddress(FirstObject.Name);
            GetMemoryAddress(SecondObject.Name);



            Console.WriteLine(FirstObject.Name);
            Console.WriteLine(SecondObject.Name);


            // Change name of the copy without affecting the original
            SecondObject.Name = "Changed Name";


            
            Console.WriteLine(FirstObject.Name);
            Console.WriteLine(SecondObject.Name);
        }

        public static void GetMemoryAddress(object obj)
        {
            GCHandle gch = GCHandle.Alloc(obj, GCHandleType.Pinned);
            IntPtr pObj = gch.AddrOfPinnedObject();
            Console.WriteLine(pObj.ToString());
        }


        public static T DeepClone<T>(T obj)
        {
            using var ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            ms.Position = 0;

            return (T)formatter.Deserialize(ms);
        }
    }
}

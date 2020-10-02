using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IGraphicObject
    {
        void Draw(); //TODO
    }

    class Circle : IGraphicObject
    {
        //TODO
        private string name;

        public Circle(string name) { this.name = name; }

        public void Draw()
        {
            Console.WriteLine("Kreis: {0}", name);
        }
    }

    class Rectangle : IGraphicObject
    {
        //TODO
        private string name;

        public Rectangle(string name) { this.name = name; }

        public void Draw()
        {
            Console.WriteLine("Rechteck: {0}", name);
        }
    }

    class Compound : IGraphicObject
    {
        private string name;
        List<IGraphicObject> objList = new List<IGraphicObject>();

        public Compound(string name) { this.name = name; }

        public void Draw()
        {
            Console.WriteLine("Verbindung: {0}", name);
            foreach (IGraphicObject g in objList)
            {
                g.Draw();
            }
            Console.WriteLine("Ende-Verbindung: {0}", name);
        }
        public void Add(IGraphicObject g)
        {
            objList.Add(g);
        }
    }
}

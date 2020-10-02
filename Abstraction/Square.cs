using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Square : Polygon
    {
        // TODO: Felder implementieren
        private float _x1;
        private float _y1;
        private float _length;
        private const int _numSides = 4;

        // TODO: Konstruktor implementieren
        public Square(float x1, float y1, float length)
        {
            _x1 = x1;
            _y1 = y1;
            _length = length;
        }

        // TODO: Basis-Members implementieren
        public override int NumSides
        {
            get { return _numSides; }
        }

        public override float Area()
        {
            return _length * _length;
        }

        // TODO: X1 / X2 implementieren
        public float X1
        {
            get { return _x1; }
            set { _x1 = value; }
        }

        public float X2
        {
            get { return _x1 + _length; }
        }

        // TODO: Y1 / Y2 implementieren
        public float Y1
        {
            get { return _y1; }
            set { _y1 = value; }
        }

        public float Y2
        {
            get { return _y1 + _length; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriskaFigurer
{
    public abstract class Shape
    {
        // fältet _length representerar en figurs längd
        private double _length;

        // fältet _width representerar en figurs bredd
        private double _width;

        // egenskapen Area publik abstrakt double representerande figurs area
        public abstract double Area
        {
            get;
        }

        // egenskapen Length publik double som kapslar in fältet _length, set-metoden ska validera att värdet är större än noll
        public double Length
        {
            get { return _length; }
            set
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Felaktig längd angiven");
                }
                else { _length = value; }
            }
        }

        // egenskapen Perimeter publik abstrakt double representerande en figurs omkrets
        public abstract double Perimeter
        {
            get;
        }

        // egenskapen Width publik double som kapslar in _width, validera att värdet är större än noll
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Felaktig bredd angiven");
                }
                else { _width = value; }
            }
        }

        // Konstruktor, ska vara protected, ansvara för att fälten via egenskaperna till delas värdena som konstruktorns parametrar har
        public Shape()
            : this(0, 0)
        {

        }
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // metoden ToString() publik, överskuggar den som finns i basklassen object. Ska returnera en sträng representerande värdet av en instans
        public override string ToString()
        {
            return null;
        }
    }
    
    // definera typen ShapeType
    enum ShapeType { Ellipse, Rectangle };
}

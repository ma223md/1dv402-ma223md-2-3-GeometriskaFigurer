using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriskaFigurer
{
    class Rectangle : Shape
    {
        // egenskapen Area publik double som ska ge rektangelns area
        public override double Area
        {
            get { return (base.Length * base.Width); }
        }

        // egenskapen perimeter publik double som ska ge rektangelns area
        public override double Perimeter
        {
            get { return (Length * 2) + (Width * 2); }
        }

        // konstruktorn anropar basklassens konstruktor för att ge nytt objekt längd och bredd
        public Rectangle() : base()
        {
            
        }
    }
}

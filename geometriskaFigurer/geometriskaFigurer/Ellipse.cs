
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriskaFigurer
{
    class Ellipse : Shape
    {
        // egenskapen Area publik double som ska ge en ellips area
        public override double Area
        {
            get { return Math.PI * (base.Length / 2) * (base.Width / 2); }
        }

        // egenskapen perimeter publik double som ska ge en ellips omkrets
        public override double Perimeter
        {
            get 
            { 
                double a = (base.Length / 2);
                double b = (base.Width / 2);
                return Math.PI * Math.Sqrt((2 * (a * a)) + (2 * b * b)); 
            }
        }

        // konstruktorn ska genom anrop av basklassens konstruktor se till att det nya objektets längd och bredd sätts
        public Ellipse() : base()
        {
            
        }

        public Ellipse(double length, double width) : base(length, width)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriskaFigurer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main ska anropa ViewMenu() för att visa en meny
            ViewMenu();
            // Låt användaren ange menyval
            Console.Write("Ange menyval [0-20]: ");
            string inputText = Console.ReadLine();  // läs in val
            int input = int.Parse(inputText); // översätt till double

            if (input < 0 || input > 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Ange ett ett tal mellan 0-2");
                Console.ResetColor();
            }
            // Anropa CreateShape för att informera om vilken typ av figur som ska skapas
            else if (input == 1)
            {
                ViewShapeDetail(CreateShape(ShapeType.Ellipse));
            }

            else if (input == 2)
            {
                ViewShapeDetail(CreateShape(ShapeType.Rectangle));
            }
            // avsluta
            else if (input == 0)
            {
                return;
            } 

        }

        // metoden CreateShape, läser in en figurs längd och bredd, skapa objektet och retunera en referens till det.
        private static Shape CreateShape(ShapeType shapeType)
        {
            Shape shape = null;

            if (shapeType == ShapeType.Ellipse)
            {
                double length = ReadDoubleGreaterThanZero("Ange ellipsens höjd: ");
                double width = ReadDoubleGreaterThanZero("Ange ellipsens bredd: ");

                shape = new Ellipse();
                shape.Length = length;
                shape.Width = width;
            }

            else
            {
                double length = ReadDoubleGreaterThanZero("Ange rektangelns höjd: ");
                double width = ReadDoubleGreaterThanZero("Ange rektangelns bredd: ");

                shape = new Rectangle();
                shape.Length = length;
                shape.Width = width;
            }

            return shape;
        }

        // metoden ska returnera ett värde som är större än 0
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            Console.Write(prompt);  //skriv ut ange längd
            string inputText = Console.ReadLine();  // läs in längd
            double input = double.Parse(inputText); // översätt till double

            // skriv ut felmeddelande om input är mindre än 0, ge ny chans
            if (input < 0)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("FEL! Ange ett flyttal större än 0");
                Console.ResetColor();
                return 0;
            }

            else { return input; } // returnera det inskrivna värdet
        }

        // metoden ska presentera en meny
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("================================================");
            Console.WriteLine("=                                              =");
            Console.WriteLine("=             Geometriska figurer              =");
            Console.WriteLine("=                                              =");
            Console.WriteLine("================================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("0. Avsluta.");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("2. Rektangel.");
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine();
        }

        //metoden ska presentera en figurs detaljer
        private static void ViewShapeDetail(Shape shape)
        {
            double length = shape.Length;
            double width = shape.Width;
            double area = shape.Area;
            double perimeter = shape.Perimeter;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("================================================");
            Console.WriteLine("=                  Detaljer                    =");
            Console.WriteLine("================================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Höjd   : {0, 10}", length);
            Console.WriteLine("Bredd  : {0, 10}", width);
            Console.WriteLine("Omkrets: {0, 10}", perimeter);
            Console.WriteLine("Area   : {0, 10}", area);
            Console.WriteLine();
            Console.WriteLine("================================================");
        }
    }
}

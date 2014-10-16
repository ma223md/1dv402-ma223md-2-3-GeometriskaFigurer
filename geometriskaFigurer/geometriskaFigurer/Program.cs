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
            do
            {
                int input;
                Console.Write("Ange menyval [0-20]: ");
                string inputText = Console.ReadLine();  // läs in val

                try
                {
                    input = int.Parse(inputText); // översätt till int

                    if (input < 0 || input > 2) // fånga fel om talet är för lågt eller för högt
                    {
                        ViewErrorMessage("FEL! Ange ett ett tal mellan 0-2");
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
                catch (FormatException) // fånga formatfel
                {
                   ViewErrorMessage("FEL! Ange ett flyttal större än 0");
                }



            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        // metoden CreateShape, läser in en figurs längd och bredd, skapa objektet och retunera en referens till det.
        private static Shape CreateShape(ShapeType shapeType)
        {
            Shape shape = null;

            if (shapeType == ShapeType.Ellipse)
            {
                double length = ReadDoubleGreaterThanZero("Ange ellipsens höjd: ");
                double width = ReadDoubleGreaterThanZero("Ange ellipsens bredd: ");

                shape = new Ellipse(length, width);
            }

            else
            {
                double length = ReadDoubleGreaterThanZero("Ange rektangelns höjd: ");
                double width = ReadDoubleGreaterThanZero("Ange rektangelns bredd: ");

                shape = new Rectangle(length, width);
            }

            return shape;
        }

        // metoden ska returnera ett värde som är större än 0
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            do
            {
                Console.Write(prompt);

                try
                {
                    double input = double.Parse(Console.ReadLine());
                    if (input < 0) // fånga fel om talet är för lågt
                    {
                        ViewErrorMessage("FEL! Ange ett flyttal större än 0");
                    }

                    else
                    {
                        return input;
                    }
                }

                catch (FormatException) // fånga formatfel
                {
                    ViewErrorMessage("FEL! Ange ett flyttal");
                }

            } while (true);
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
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("================================================");
            Console.WriteLine("=                  Detaljer                    =");
            Console.WriteLine("================================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(shape.ToString());
            Console.WriteLine();
            Console.WriteLine("================================================");
        }

        private static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tryck tangent för att fortsätta");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}

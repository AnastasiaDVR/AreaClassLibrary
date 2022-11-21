using System;
using AreaClassLibrary;

namespace ConsoleShow
{
    class Program
    {
        // написать инструкцию по развёртке
        //
        //
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Circle");
                Console.WriteLine("2 - Triangle");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("Enter code action: ");
                int.TryParse(Console.ReadLine(), out number);

                switch (number)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Bye");
                        break;

                    case 1:
                        Console.Clear();
                        Console.Write("Radius: ");
                        double.TryParse(Console.ReadLine(), out double radius);
                        Console.WriteLine("Result: " + radius.AreaCircle());
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("a: ");
                        double.TryParse(Console.ReadLine(), out double sideA);
                        Console.Write("b: ");
                        double.TryParse(Console.ReadLine(), out double sideB);
                        Console.Write("c: ");
                        double.TryParse(Console.ReadLine(), out double sideC);

                        double[] sides = { sideA, sideB, sideC };
                        Console.WriteLine("Result: " + sides.AreaTriangle());

                        if (sides.isRightTringle())
                            Console.WriteLine("right triangle");

                        Console.ReadKey();
                        break;
                }
            } while (number != 0);
            Console.ReadKey();
        }
    }
}

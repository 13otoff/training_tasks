using System;
using System.Collections.Generic;
using Task_2._1._2.Figures;

namespace Task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<Figure> { };

            while (true)
            {
                Console.WriteLine("Choose action:{0}1. Add figure{0}2. Output figures{0}3. Clear area{0}4. Exit", Environment.NewLine);

                bool succes = int.TryParse(Console.ReadLine(), out int number);
                if (succes)
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Choose type of figure:{0}1. Point{0}2. Line{0}3. Circle{0}4. Rectangle{0}" +
                                "5. Ring{0}6. Round{0}7. Square{0}8. Triangle{0}", Environment.NewLine);
                            bool succes2 = int.TryParse(Console.ReadLine(), out int number2);
                            if (succes2)
                            {
                                switch (number2)
                                {
                                    case 1:
                                        Console.WriteLine("Enter coordinates of point");
                                        Point p = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                                        figures.Add(p);
                                        break;
                                    case 2:
                                        Console.WriteLine("Enter length of line");
                                        int length = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter coordinates of line");
                                        Line l = new Line(length, new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                                        figures.Add(l);
                                        break;
                                    case 3:
                                        Console.WriteLine("Enter radius of circle");
                                        int radius = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter coordinates of center");
                                        Circle c = new Circle(radius, new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                                        figures.Add(c);
                                        break;
                                    case 4:
                                        Console.WriteLine("Enter sides of rectangle");
                                        int sideA = int.Parse(Console.ReadLine());
                                        int sideB = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter coordinates of position");
                                        Rectangle rec = new Rectangle(sideA, sideB, new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                                        figures.Add(rec);
                                        break;
                                    case 5:
                                        Console.WriteLine("Enter inner and outer radius of ring");
                                        int inner = int.Parse(Console.ReadLine());
                                        int outer = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter coordinates of center");
                                        Ring ring = new Ring(inner, outer, new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                                        figures.Add(ring);
                                        break;
                                    case 6:
                                        Console.WriteLine("Enter radius of round");
                                        int _radius = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter coordinates of center");
                                        Round r = new Round(_radius, new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                                        figures.Add(r);
                                        break;
                                    case 7:
                                        Console.WriteLine("Enter side of square");
                                        int side = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter coordinates of position");
                                        Square s = new Square(side, new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                                        figures.Add(s);
                                        break;
                                    case 8:
                                        Console.WriteLine("Enter sides of triangle");
                                        int _sideA = int.Parse(Console.ReadLine());
                                        int _sideB = int.Parse(Console.ReadLine());
                                        int _sideC = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter coordinates of position");
                                        Triangle t = new Triangle(_sideA, _sideB, _sideC, new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                                        figures.Add(t);
                                        break;
                                    default:
                                        Console.WriteLine("Enter number 1-8, please");
                                        break;
                                }
                                if (number2 > 0 && number2 < 9)
                                    Console.WriteLine("Created");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"Figures:{ Environment.NewLine}");
                            foreach (var item in figures)
                            {
                                Console.Write($"{item}{Environment.NewLine}");
                            }
                            Console.WriteLine();
                            break;
                        case 3:
                            figures.Clear();
                            Console.WriteLine("Deleted all figures");
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter number 1-4, please");
                            break;
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}


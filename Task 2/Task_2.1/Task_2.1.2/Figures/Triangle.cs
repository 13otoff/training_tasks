using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Triangle: Figure
    {
        public Triangle(int sideA, int sideB, int sideC, Point start)
        {
            if (IsTriangle)
            {
                SideA = new Line(sideA, start);
                SideB = new Line(sideB, start);
                SideC = new Line(sideC, start);
                Start = start;
            }
        }
        public Point Start { get; set; }
        public Line SideA { get; set; }
        public Line SideB { get; set; }
        public Line SideC { get; set; }

        private bool IsTriangle
        {
            get
            {
                if (SideA.Length >= SideB.Length + SideC.Length || SideB.Length >= SideA.Length + SideC.Length 
                    || SideC.Length >= SideB.Length + SideA.Length)
                {
                    return false;
                }
                return true;
            }
        }

        public int GetLength => SideA.Length + SideB.Length + SideC.Length;

        public double GetArea
        {
            get 
            { 
                double halfperimeter = (SideA.Length + SideB.Length + SideC.Length) / 2;
                return Math.Sqrt(halfperimeter * (halfperimeter - SideA.Length) * (halfperimeter - SideB.Length)
                    * (halfperimeter - SideC.Length));
            }
        }
        public override string ToString()
        {
            return string.Format($"Is Triangle. Side a: {SideA.Length}, side b: {SideB.Length}," +
                $" side c: {SideC.Length}, position: ({Start.X}, {Start.Y})");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
     class Rectangle: Figure
    {
        public Rectangle(int sideA, int sideB, Point start)
        {
            SideA = new Line(sideA, start);
            SideB = new Line(sideB, start);
            Start = start;
        }
        public Point Start { get; set; }
        public Line SideA { get; set; }
        public Line SideB { get; set; }

        public int GetLength => 2 * (SideA.Length + SideB.Length);

        public int GetArea => SideA.Length * SideB.Length;

        public override string ToString()
        {
            return string.Format($"Is Rectangle. Side a: {SideA.Length}, side b: {SideB.Length}, position: ({Start.X}, {Start.Y})");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;

namespace Task_2._1._2
{
    class Circle: Figure
    {
        public Point Center { get; set; }
        private int radius;

        public int Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                else
                    throw new ArgumentException("Invalid");
            }
        }

        public double GetLength => 2 * Math.PI * Radius;

        public Circle(int radius, Point center)
        {
            Radius = radius;
            Center = center;
        }

        public override string ToString()
        {
            return string.Format($"Is Circle. Radius: {Radius}, Center: ({Center.X}, {Center.Y})");
        }
    }
}

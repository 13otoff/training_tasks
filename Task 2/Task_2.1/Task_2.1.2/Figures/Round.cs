using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Round : Circle
    {
        public Round(int radius, Point center):base(radius, center)
        {

        }

        public double GetArea => Math.PI * Radius * Radius;

        public override string ToString()
        {
            return string.Format($"Is Round. Radius: {Radius}, Center: ({Center.X}, {Center.Y})");
        }
    }
}

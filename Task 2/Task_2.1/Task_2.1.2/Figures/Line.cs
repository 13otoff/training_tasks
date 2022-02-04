using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Line: Figure
    {
        public Line(int length, Point start)
        {
            Length = length;
            Start = start;
        }
        public Point Start { get; set; }

        private int length;

        public int Length
        {
            get { return length; }
            set {
                if (value > 0)
                    length = value;
                else
                    throw new ArgumentException("Invalid");
            }
        }

        public override string ToString()
        {
            return string.Format($"Is Line. Length: {Length}, start position: ({Start.X}, {Start.Y})");
        }
    }
}

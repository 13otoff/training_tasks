using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Square: Line
    {
        public Square(int length, Point start):base(length, start)
        {

        }

        public int GetLength => 4 * Length;

        public int GetArea => Length * Length;

        public override string ToString()
        {
            return string.Format($"Is Square. Length of side: {Length}, position: ({Start.X}, {Start.Y})");
        }
    }
}

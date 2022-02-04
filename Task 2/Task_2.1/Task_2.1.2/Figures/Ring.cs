using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;

namespace Task_2._1._2
{
    class Ring: Figure
    {
        public Ring(int innerR, int outerR, Point center)
        {
            innerRound = new Round(innerR, center);
            outerRound = new Round(outerR, center);
            Center = center;
        }
        public Point Center { get; set; }

        private Round innerRound;

        public int InnerR
        {
            get { return innerRound.Radius; }
            set {
                if (innerRound.Radius < outerRound.Radius)
                    innerRound.Radius = value;
                else
                    throw new ArgumentException("Invalid radius");
            }
        }

        private Round outerRound;

        public int OuterR
        {
            get { return outerRound.Radius; }
            set {
                if (innerRound.Radius < outerRound.Radius)
                    outerRound.Radius = value;
                else
                    throw new ArgumentException("Invalid radius");
            }
        }

        public double GetLength => 2 * Math.PI * (InnerR + OuterR);

        public double GetArea => Math.PI * (OuterR * OuterR - InnerR * InnerR);

        public override string ToString()
        {
            return string.Format($"Is Ring. Inner radius: {InnerR}, outer radius: {OuterR}, Center: ({Center.X}, {Center.Y})");
        }
    }
}

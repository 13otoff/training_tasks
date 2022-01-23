using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1
{
    class Game
    {
		public static bool Play = true;

		public static List<GameObject> Objects = new List<GameObject>();
		public static Player Player;

		public const int Width = 50;
		public const int Height = 25;

		public static GameMode Mode = GameMode.Location;

		public static int Selection = -1;
	}
}

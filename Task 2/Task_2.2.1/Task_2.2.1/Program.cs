using System;

namespace Task_2._2._1
{
	class Program
	{
		static void Main(string[] args)
		{
			InitGame();
			Update();
		}

		static void InitGame()
		{
			Random r = new Random();
			int w = Game.Width- 1;
			int h = Game.Height- 1;

			Game.Player = new Player("Hero", new Position(5, 10, 1, 1));

			Game.Objects.Add(Game.Player);

			Game.Objects.Add(new NPC("Enemy 1", new Position(r.Next(1, w), r.Next(1, h), 3, 3)));
			Game.Objects.Add(new NPC("Enemy 2", new Position(r.Next(1, w), r.Next(1, h), 2, 2)));
			Game.Objects.Add(new NPC("Enemy 3", new Position(r.Next(1, w), r.Next(1, h), 2, 2)));
			Game.Objects.Add(new NPC("Enemy 4", new Position(r.Next(1, w), r.Next(1, h), 2, 2)));
			Game.Objects.Add(new NPC("Enemy 5", new Position(r.Next(1, w), r.Next(1, h), 2, 2)));

			Game.Player.Inventory.Add(new Drug("Hyper", 50));
			Game.Player.Inventory.Add(new Food("Cake", 12));
		}

		static void Update()
		{
			ConsoleKeyInfo e;

			while (Game.Play)
			{
				switch (Game.Mode)
				{
					case GameMode.Location:
						Graphics.Draw(Game.Objects);

						e = Console.ReadKey();

						Location.Controll(e);
						break;

					case GameMode.Inventory:

						if (Game.Player.Inventory.Count == 0)
						{
							Inventory.Close();
							break;
						}

						Graphics.DrawInventory(Game.Player.Inventory);

						e = Console.ReadKey();

						Inventory.Controll(e);
						break;
				}

			}
		}
	}
}
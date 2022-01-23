using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1
{
	public class Player : GameObject
	{
		private List<Item> inventory;

		public Player(string name, Position position)
			: base(name, position)
		{
			inventory = new List<Item>();
		}

		public void Use(int index)
		{
			if (inventory[index] is IUsable)
			{
				IUsable item = inventory[index] as IUsable;
				item.Use(this);

				inventory.RemoveAt(index);
			}
			else
			{
				Console.WriteLine("You can't use that!");
			}
		}

		public List<Item> Inventory
		{
			get
			{
				return this.inventory;
			}
		}
	}
}

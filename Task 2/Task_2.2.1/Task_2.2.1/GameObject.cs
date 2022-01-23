using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1
{
    public class GameObject
    {
		private string name;

		private Position position;

		private int hpFull;
		private int hp;

		public GameObject(string name, Position position)
		{
			this.name = name;

			this.position = position;

			hpFull = 100;
			hp = 100;
		}

		public void Attack(GameObject obj)
		{
			obj.TakeDamage(10);
		}

		public void TakeDamage(int dmg)
		{
			this.hp -= dmg;
			Console.WriteLine($"\n{this.Name} has taken {dmg} damage");

			Console.ReadKey();

			if (hp <= 0)
			{
				Die();
			}
		}

		private void Die()
		{
			Console.WriteLine($"\n{this.Name} died");
			Console.ReadKey();

			Game.Objects.Remove(this);
		}



		public void Heal(int val)
		{
			if (hp + val > hpFull)
			{
				val = val - (hp + val - hpFull);
			}

			hp += val;

			Console.WriteLine($"\n{name} healed {val} HP!");
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}

		public string Name
		{
			get
			{
				return this.name;
			}
		}

		public Position Position
		{
			get
			{
				return this.position;
			}
		}

		public int HP
		{
			get
			{
				return this.hp;
			}
		}

		public int HPFull
		{
			get
			{
				return this.hp;
			}
		}

	}
}

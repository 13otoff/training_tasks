using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1
{
    class Drug: Item, IUsable
    {
		private int hpVal;

		public Drug(string name, int hpVal)
			: base(name)
		{
			this.hpVal = hpVal;
		}

		public void Use(Player p)
		{
			p.Heal(hpVal);
		}

		public string Description
		{
			get
			{
				return $"A flask of {this.Name} restores {this.hpVal} HP.";
			}
		}
	}
}

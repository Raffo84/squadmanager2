using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Entities {
	public abstract class Faction {
		public bool NPC { get; set; }
		public string Name { get; set; }
		public KeyValuePair<Faction, int> Relationships { get; set; }

		public static Faction PCFaction { get; }
	}
}

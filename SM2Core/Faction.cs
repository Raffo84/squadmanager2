using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core {
	public interface Faction {
		bool NPC { get; set; }
		string Name { get; set; }
	}
}
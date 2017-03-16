using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core {
	public interface Actor {
		Faction Faction { get; set; }
		Attribute Attribute { get; set; }
		Skill Skill { get; set; }
		DerivedValue DerivedValue { get; set; }
		Traits Traits { get; set; }
		CharacterSheet CharacterSheet { get; set; }
		Infobox Infobox { get; set; }
		Marker Marker { get; set; }
		Possession Possession { get; set; }
		string Name { get; set; }
	}
}
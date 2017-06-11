using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Entities {
	public interface Actor {
		Faction Faction { get; set; }
		Skill Skill { get; set; }
		DerivedValue DerivedValue { get; set; }
		string Name { get; set; }
		Traits Traits { get; set; }
		Attribute Attribute { get; set; }
		Items.Possession Possession { get; set; }
		Visualization.CharacterSheet CharacterSheet { get; set; }
		Visualization.Infobox Infobox { get; set; }
		Visualization.Marker Marker { get; set; }
	}
}
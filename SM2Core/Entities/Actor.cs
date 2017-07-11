using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Entities {
	public interface Actor {
		String Name { get; set; }

		Faction Faction { get; set; }
		List<Faction> Relationships { get; set; }
		List<Skill> Skills { get; set; }
		List<DerivedValue> DerivedValues { get; set; }
		List<Traits> Traits { get; set; }
		List<Attribute> Attributes { get; set; }
		List<Items.Possession> Inventory { get; set; }
		Visualization.CharacterSheet CharacterSheet { get; set; }
		Visualization.Infobox Infobox { get; set; }
		Visualization.Marker Marker { get; set; }
	}
}

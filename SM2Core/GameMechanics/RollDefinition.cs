using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public interface RollDefinition {
		List<BaseDie> Dice { get; set; }
		//Items.Possession Possession { get; set; }	// was this on purpose or on accident? Why would the roll definition (generally) depend on items?
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public interface RollDefinition {
		BaseDie Dice { get; set; }
		Items.Possession Possession { get; set; }
	}
}
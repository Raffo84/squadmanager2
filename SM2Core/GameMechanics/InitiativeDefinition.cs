using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public interface InitiativeDefinition {
		RollDefinition RollDefinition { get; set; }
		Entities.Actor Actor { get; set; }
	}
}
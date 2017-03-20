using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core {
	public interface InitiativeDefinition {
		RollDefinition RollDefinition { get; set; }
		Actor Actor { get; set; }
	}
}
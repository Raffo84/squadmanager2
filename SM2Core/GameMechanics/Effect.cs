using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public interface Effect {
		String Name { get; set; }
		EffectSource Source { get; set; }
		List<Modifier> Modifiers { get; set; }
		TimeFrame Duration { get; set; }
	}
}
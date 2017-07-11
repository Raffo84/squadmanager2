using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Entities {
	public interface Attribute: GameMechanics.EffectSource {
		string ShortName { get; set; }
		int Value { get; set; }
	}
}
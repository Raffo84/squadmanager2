using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Entities {
	public interface Skill: GameMechanics.EffectSource {
		Attribute Attribute { get; set; }
		int Value { get; set; }
	}
}
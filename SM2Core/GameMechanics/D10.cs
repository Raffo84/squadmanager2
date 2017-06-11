using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public class D10: BaseDie {
		public override int Roll() {
			return RNG.NextUniformInt(10) + 1;
		}
	}
}
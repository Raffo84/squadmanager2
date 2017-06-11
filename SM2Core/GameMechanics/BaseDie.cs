using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public abstract class BaseDie {
		public RandomnessProvider RNG = new RandomnessProvider();
		abstract public int Roll();
	}
}

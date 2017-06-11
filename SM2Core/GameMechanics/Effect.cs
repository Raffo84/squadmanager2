using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public interface Effect {
		Modifier Modifier { get; set; }
		TimeUnit Duration { get; set; }
	}
}
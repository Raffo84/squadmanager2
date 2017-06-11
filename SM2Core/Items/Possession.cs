using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Items {
	public interface Possession {
		Visualization.Marker Marker { get; set; }
		GameMechanics.Modifier Modifier { get; set; }
	}
}
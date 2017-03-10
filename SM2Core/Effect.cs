using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core {
	public interface Effect {
		TimeUnit Duration { get; set; }
		Modifier Modifier { get; set; }
	}
}
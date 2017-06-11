using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Scenes {
	public interface Scene {
		MarkerList MarkerList { get; set; }
		Map Map { get; set; }
		//MapList LevelList { get; set; }	// Ich hab's vergessen... hatten wir das noch im Plan, und wenn ja, was macht das? ^^  -RS
	}
}
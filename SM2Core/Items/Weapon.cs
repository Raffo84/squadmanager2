﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Items {
	public interface Weapon: Item {
		Ammunition Ammunition { get; set; }
	}
}
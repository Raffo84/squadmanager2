﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Items {
	public interface AbstractItem: Possession {
		string Name { get; set; }
	}
}
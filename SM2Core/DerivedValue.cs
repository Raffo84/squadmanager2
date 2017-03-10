using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core {
	public interface DerivedValue {
		Attribute Attribute { get; set; }
		Skill Skill { get; set; }
	}
}
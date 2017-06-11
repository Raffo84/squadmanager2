using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Entities {
	public interface DerivedValue {
		Skill Skill { get; set; }
		Attribute Attribute { get; set; }
	}
}
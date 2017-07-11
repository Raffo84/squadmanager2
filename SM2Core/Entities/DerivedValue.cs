using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.Entities {
	public interface DerivedValue {
		List<Skill> Skills { get; set; }
		List<Attribute> Attributes { get; set; }
	}
}
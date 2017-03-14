using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core
{
    public interface Environment
    {
        Cover Cover { get; set; }
        Sight Sight { get; set; }
        Infobox Infobox { get; set; }
    }
}
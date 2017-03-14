using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core
{
    public interface Scene
    {
        MapList LevelList { get; set; }
        MarkerPositionList MarkerList { get; set; }
    }
}
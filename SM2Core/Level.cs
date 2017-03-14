using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core
{
    public interface Map
    {
        string ImageFile { get; set; }
        int Name { get; set; }
        Environment Enviorment { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IInfo:IComponent
{
    int type { get; set; }

    int res { get; set; }
}
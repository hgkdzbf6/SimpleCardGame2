using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICharacterInfo:IInfo
{
    Cost cost { get; set; }

    Health health { get; set; }
}
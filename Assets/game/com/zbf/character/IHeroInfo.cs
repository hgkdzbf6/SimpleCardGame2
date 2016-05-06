using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IHeroInfo:IInfo,ICharacterInfo
{
    Armor armor { get; set; }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IHero
{
    IPower power { get; set; }
    IHeroInfo hero_info { get; set; }
}
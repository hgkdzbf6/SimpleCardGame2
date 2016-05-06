using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICardInfo
{
    int card_name { get; set; }
    int cost { get; set; }
    int type { get; set; }
    int res { get; set; }
}
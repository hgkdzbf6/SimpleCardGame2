using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICardInfo:IInfo
{
    Name card_name { get; set; }

    void combo();
    void run(string target);
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IComponent
{
    int id { get; set; }

    void toString();
    void hashCode();
    void equals();
}
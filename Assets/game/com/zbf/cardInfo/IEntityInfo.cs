using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IEntityInfo:ICardInfo,ICharacterInfo
{

    void alive();

    void enrage();

    void deathRattle();

    void causeDamage();

    void battleCry();
}
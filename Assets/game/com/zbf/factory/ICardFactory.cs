using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICardFactory
{
    ICard createNewCard(IFind id);
    void createNewCard();
    void createNewMinionCard();
    void createNewSpellCard();
    void createNewWeaponCard();
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boots : Armor
{
    public Status Status { get; private set; }

    public Boots(int mana, int health)
    {
        Status = new Status()
        {
            Mana = mana,
            Health = health
        };
    }
}

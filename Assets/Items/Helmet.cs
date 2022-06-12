using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : Armor
{
    public Status Status { get; private set; }

    public Helmet(int mana, int damage)
    {
        Status = new Status()
        {
            Mana = mana,
            Damage = damage
        };
    }
}

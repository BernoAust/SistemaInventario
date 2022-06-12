using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Armor
{
    public Status Status { get; private set; }

    public Chest(int mana, int health)
    {
        Status = new Status()
        {
            Mana = mana,
            Health = health
        };
    }
}

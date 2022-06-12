using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    public Status Status { get; private set; }

    public Weapon(int damage, StatusType type, int secondaryValue)
    {
        Status.Damage = damage;

        switch(type)
        {
            case StatusType.Mana:
                Status.Mana = secondaryValue; break;

            case StatusType.Health:
                Status.Health = secondaryValue; break;

            default:
                Debug.Log("O tipo especificado não existe"); break;
        }
    }

    public override void Use()
    {
        Debug.Log("A arma foi equipada");
    }
}

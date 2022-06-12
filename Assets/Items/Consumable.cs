using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{
    public Status Status { get; private set; }

    public Consumable(StatusType type, int amount)
    {
        switch(type)
        {
            case StatusType.Mana:
                Status.Mana = amount; break;

            case StatusType.Health:
                Status.Health = amount; break;

            case StatusType.Damage:
                Status.Damage = amount; break;

            default:
                Debug.Log("O tipo especificado não existe"); break;
        }
    }

    public override void Use()
    {
        Debug.Log("O consumivel foi usado");
    }
}

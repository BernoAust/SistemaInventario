using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Armor : Item
{
    public override void Use()
    {
        Debug.Log("A armadura foi equipada");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status
{
    public int Damage { get; set; }
    public int Mana { get; set; }
    public int Health { get; set; }
}

public enum StatusType
{
    Damage = 1,
    Mana = 2,
    Health = 3
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public Slot<Helmet> HelmetSlot;
    public Slot<Chest> ChestSlot;
    public Slot<Boots> BootsSlot;
    public Slot<Weapon> WeaponSlot;

    public List<Slot<Item>> Inventory = new List<Slot<Item>>();
}

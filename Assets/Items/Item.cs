using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public string Name { get; }
    public string Description { get; }
    public int Level { get; }

    public virtual void Use()
    {
        Debug.Log("O item foi utilizado");
    }

    public virtual void ShowInfo()
    {
        Debug.Log($"Nome: {Name} / Nível: {Level} / Descrição: {Description}");
    }
}

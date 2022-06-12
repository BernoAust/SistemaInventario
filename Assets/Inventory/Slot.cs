using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot<TClass> : MonoBehaviour
{
    private Item _item;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.GetType() == typeof(TClass))
        {
            if(_item != null)
            {
                _item.gameObject.GetComponent<Draggable>().TargetDestination = other.GetComponent<Draggable>().LastPosition;

            }
            
            _item = other.gameObject.GetComponent<TClass>() as Item;
            other.GetComponent<Draggable>().TargetDestination = gameObject.transform.position;

        }
    }

}

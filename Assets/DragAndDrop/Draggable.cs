using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public bool isDragging;
    private Collider2D _clldr;
    private DragController _DC;
    public Vector3 LastPosition;
    private float _movementSpeed = 15f;
    public System.Nullable<Vector3> TargetDestination;

    private void Start()
    {
        _clldr = GetComponent<Collider2D>();
        _DC = FindObjectOfType<DragController>();
    }

    private void FixedUpdate()
    {
        if(TargetDestination.HasValue)
        {
            if(isDragging)
            {
                TargetDestination = null;
                return;
            }

            if(transform.position == TargetDestination)
            {
                gameObject.layer = (int) Layer.Default;
                TargetDestination = null;
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, TargetDestination.Value, _movementSpeed * Time.deltaTime);
            }
        }
    }

    /*private void OnTriggerEnter(Collider2D other)
    {
        Draggable collidedDraggable = other.GetComponent<Draggable>();

        if(collidedDraggable != null && _DC.LastDrag.gameObject == gameObject)
        {
            ColliderDistance2D colliderDistance2D = other.Distance(_clldr);
            Vector3 diference = new Vector3(colliderDistance2D.normal.x, colliderDistance2D.normal.y) * colliderDistance2D.distance;
            transform.position -= diference;
        }
    }*/
}

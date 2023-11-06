using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Draggableitem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Mouse.current.position.ReadValue();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
    }
}

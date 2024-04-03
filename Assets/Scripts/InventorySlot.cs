using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
    [SerializeField] InputHandler inputHandler;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;

        }
        else //swap items
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            Transform originalParent = draggableItem.parentAfterDrag;

            Transform itemInSlot = transform.GetChild(0);
            draggableItem.parentAfterDrag = transform;
            itemInSlot.SetParent(originalParent);
            dropped.transform.SetParent(transform);
            itemInSlot.SetAsLastSibling();

            inputHandler.SwitchKey(draggableItem.name, itemInSlot.name);
        }

    }
}

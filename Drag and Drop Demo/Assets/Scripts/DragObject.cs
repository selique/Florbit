using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class DragObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    void IBeginDragHandler.OnBeginDrag(PointerEventData pointerEventData)
    {
        Debug.Log("start DragObject OnBeginDrag");
    }
    public void OnDrag(PointerEventData pointerEventData)
    {
        Debug.Log("start DragObject OnDrag");
    }
    public void OnEndDrag(PointerEventData pointerEventData)
    {
        Debug.Log("start DragObject OnEndDrag");
    }
}
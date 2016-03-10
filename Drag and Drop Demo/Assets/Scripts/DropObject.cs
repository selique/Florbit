using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropObject : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("start DropObject OnPointerEnter");
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("start DropObject OnPointerExit");
    }
    public void OnDrop(PointerEventData pointerEventData)
    {
        Debug.Log("start DropObject OnDrop");
    }
}
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class DragObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
 public Text palavra;
 
 palavra = Text.palavra("BOLA");
 

    void Start(){
        public string[] Posicaopalavra;
        Posicaopalavra = new string[4] ; 
        Posicaopalavra[0] = "b";
        Posicaopalavra[1] = "o";
        Posicaopalavra[2] = "l";
        Posicaopalavra[3] = "a";
 for (int Posicaopalavra = 0; Posicaopalavra < 5; Posicaopalavra++)
 {
     
   inteiros[Posicaopalavra] = Posicaopalavra;
 }
 
}


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
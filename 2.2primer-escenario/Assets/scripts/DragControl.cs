
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

//SCRIPT PARA ARRASTRAR UN SPRITE

public class DragControl : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{

    Image Gato;
    public bool Pressed;

    private void Awake()
    {
        Gato = GetComponent<Image>();
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Gato.color = Color.green;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Gato.color = Color.white;
    }

}

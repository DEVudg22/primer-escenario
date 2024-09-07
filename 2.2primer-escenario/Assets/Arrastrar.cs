using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Arrastrar : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject gato;
    Vector3 startPosition;
    float zDistanceOfCamera;
    Vector3 touchOffset;

    public void OnBeginDrag(PointerEventData eventData)
    {
        gato = gameObject;
        startPosition = transform.position;
        zDistanceOfCamera = Mathf.Abs(startPosition.z - Camera.main.transform.position.z);
        touchOffset = startPosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceOfCamera));
    }

    public void OnDrag(PointerEventData eventData)
    {
        if(Input.touchCount > 1)
            return;

        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceOfCamera))+touchOffset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        gato = null;
        touchOffset = Vector3.zero;
    }

}

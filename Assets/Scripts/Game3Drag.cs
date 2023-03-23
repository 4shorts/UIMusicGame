using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Game3Drag : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    private Image _image;
    [SerializeField] private Image _imageDrop;
    [SerializeField] private int _imageValue;

    void Start()
    {
        _image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        var temp = _image.color;
        temp.a = 0.7f;
        _image.color = temp;
        _image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        var temp = _image.color;
        temp.a = 1.0f;
        _image.color = temp;
        _image.raycastTarget = true;
    }


}

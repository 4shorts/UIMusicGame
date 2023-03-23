using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Game3Drop : MonoBehaviour, IDropHandler
{
    [SerializeField] private int _imageDropValue;
    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.transform.position = transform.position;
        
    }
}

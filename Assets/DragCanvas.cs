using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragCanvas : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public GameObject videoPlayer;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log ("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log ("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        videoPlayer.SetActive(true);
        Debug.Log ("OnEndDrag");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        videoPlayer.SetActive(false);
        Debug.Log("OnEndDrag");
    }

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Level5ImgController : EventTrigger {

    private Vector2 mouseOffset;

	// Use this for initialization
	void Start () {
        transform.localPosition = new Vector3(
            Random.Range(-277.5f, 277.5f),
            Random.Range(-224, 256),
            0
            );

        GetComponent<Image>().alphaHitTestMinimumThreshold = 0.5f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnBeginDrag(PointerEventData eventData)
    {
        Vector3 worldMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 canvasMouse = transform.parent.InverseTransformPoint(worldMouse);

        mouseOffset = canvasMouse - transform.localPosition;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        Vector3 worldMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 canvasMouse = transform.parent.InverseTransformPoint(worldMouse);
        Vector2 expectPosition = (Vector2)canvasMouse - mouseOffset;

        transform.localPosition = new Vector3(
            Mathf.Clamp(expectPosition.x, -277.5f, 277.5f),
            Mathf.Clamp(expectPosition.y, -224, 256),
            0
            );

    }
}

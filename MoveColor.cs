using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveColor : MonoBehaviour
{
    public GameObject selectedObject;
    private Transform colorStartingPosition;
    Vector3 offset;
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }
        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
            selectedObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }
}

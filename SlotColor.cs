using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SlotColor : MonoBehaviour
{
    public int color = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (color == 0)
        {
            GetComponent<SpriteRenderer>().color = Color.gray;
        }
        if (color == 1)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (color == 2)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (color == 3)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }

    /*void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutColor : MonoBehaviour
{
    // Start is called before the first frame update
    public static int ReadyColor = 0;

    public void Color_Put(int color)
    {

    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

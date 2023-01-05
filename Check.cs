using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Check : MonoBehaviour
{
    public static int ReadyCheck = 0;
    void Start()
    {
       
    }

    public void OnMouseDown()
    {
        ReadyCheck = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

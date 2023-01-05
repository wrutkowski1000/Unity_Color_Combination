using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowFiller : MonoBehaviour
{
    public GameObject[] slots;
    int i = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PutColor.ReadyColor != 0)
        {
            slots[i].GetComponent<SlotColor>().color = PutColor.ReadyColor;
            PutColor.ReadyColor = 0;
            if (i == 3)
            {
                i = 0;
            } else
            {
                i++;
            }
        }
    }
}

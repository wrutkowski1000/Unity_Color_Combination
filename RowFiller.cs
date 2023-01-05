using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowFiller : MonoBehaviour
{
    public GameObject[] slots;
    public GameObject[] checkSlots;
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

        if (Check.ReadyCheck == 1)
        {
            int j = 0;
                if (slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.black;
                } 
                else if (slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j+1])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j + 2])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j + 3])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.white;
                }
                else
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.gray;
                }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowFiller : MonoBehaviour
{
    public GameObject[] slots;
    public GameObject[] checkSlots;

    public GameObject newRow;
    public static int numberOfRows = 1;
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
            for (int j = 0; j < 4; j++)
            {
                if (j < 5 && slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.black;
                } 
                else if (j < 4 && slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j+1])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (j < 3 && slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j + 2])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.white;
                }
                else if (j < 2 && slots[j].GetComponent<SlotColor>().color == ColorCombination.Combination[j + 3])
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.white;
                }
                else
                {
                    checkSlots[j].GetComponent<SpriteRenderer>().color = Color.gray;
                }
            }
            numberOfRows++;
            if (numberOfRows < 10)
            {
                Instantiate(newRow, new Vector3(transform.position.x, transform.position.y - 0.95f, transform.position.z), Quaternion.identity, this.GetComponentInParent<Transform>());
            } else
            {
                numberOfRows++;
            }
            Check.ReadyCheck = 0;
            Destroy(this);
        }
    }
}

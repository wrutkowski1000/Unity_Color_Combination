using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCombination : MonoBehaviour
{
    public static int[] Combination = new int[6];
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Combination[i] = Random.Range(1, 7);
            Debug.Log(Combination[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

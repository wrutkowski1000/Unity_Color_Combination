using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCombination : MonoBehaviour
{
    private static int[] Combination = new int[6];
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Combination[i] = Random.Range(0, 6);
            Debug.Log(Combination[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

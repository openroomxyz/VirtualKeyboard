using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RUn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 3047;
        int sum = 0;
        for(int i = 0; i < num; i++)
        {
            if(((i % 5)==0) || ((i % 3) == 0))
            {
                sum += i;
            }
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

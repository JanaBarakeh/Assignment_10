using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i =1 ; i<=10 ; i++)
        {
            int result = multiply(5,i);
             Debug.Log("5 x " + i + "=" + result);
        }
    }

     int multiply (int number1, int number2)
    {
        int mul = number1 * number2;
        return mul ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

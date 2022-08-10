using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCheck : MonoBehaviour
{
    public static int counterforlvl2 = 0;
    public void Start()
    {
        //Debug.Log("NumberCheck");
    }

    public static void Checknumber(GameObject obj)
    {
        Debug.Log(counterforlvl2);
        if (RandomObjectToTarget.generatedObject.Contains(obj))
            if (obj == RandomObjectToTarget.generatedObject[counterforlvl2])
            {
                // Debug Message
                Debug.Log("Pickup Collected");
                // >> Your Pickup Code Here <<
                obj.SetActive(false);
                counterforlvl2++;
                //Debug.Log(counterforlvl2);
            }
            else
            {
                // Debug Message
                Debug.Log("Wrong order");
                // Your Eliminate Player Code Here <<
            }

    }
}



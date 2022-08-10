using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideCheck : MonoBehaviour
{
    public string nextScene="Level 3";
    public static int counterforlvl2 = 0;
    //private List<GameObject> generatedObject;
    public RandomObjectToTarget RandomObj;

    public void Awake()       
    {
        //Debug.Log("started");

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            RandomObj.Trigger(this.gameObject);            
        }                 
    }
    /*Debug.Log(counterforlvl2);
            if (RandomObjectToTarget.generatedObject.Contains(this.gameObject))
                if (this.gameObject == RandomObjectToTarget.generatedObject[counterforlvl2])
                {
                    // Debug Message
                    Debug.Log("Pickup Collected");
                    // >> Your Pickup Code Here <<
                    this.gameObject.SetActive(false);
                    counterforlvl2++;
                    Debug.Log(counterforlvl2);
                }
                else
                {
                    // Debug Message
                    Debug.Log("Wrong order");
                    // Your Eliminate Player Code Here <<
                }
            if (counterforlvl2 == 10)
                SceneManager.LoadScene(nextScene);
            else
                Debug.Log("Not complete");*/
}

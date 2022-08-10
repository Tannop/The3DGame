using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerON : MonoBehaviour
{
    public bool hide;
    public GameObject[] targets;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // loop through the array and set them active/inactive
            for (int i = 0; i < targets.Length; i++)
            {
                targets[i].SetActive(!hide);
            }
        }
    }
}
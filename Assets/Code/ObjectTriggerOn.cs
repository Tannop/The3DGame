using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectTriggerOn : MonoBehaviour
{
    public GameObject[] enableObjects;
    public GameObject[] disableObjects;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < enableObjects.Length; i++)
                enableObjects[i].SetActive(true);
            for (int i = 0; i < disableObjects.Length; i++)
                disableObjects[i].SetActive(false);
        }
    }
}
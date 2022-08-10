using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unhide : MonoBehaviour
{
    public GameObject UnhideTarget;

    void OnTriggerEnter(Collider other)
    {
        UnhideTarget.SetActive (true);

    }
}

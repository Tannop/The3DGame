using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRenderer : MonoBehaviour
{
    public GameObject[] unhideTargets;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Started1");

        foreach (GameObject target in unhideTargets) {

            Renderer rend = target.GetComponent<Renderer>();
        if (rend.enabled)
            rend.enabled = !rend.enabled;
            Debug.Log("Started2");
        }
    }
}

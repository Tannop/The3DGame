using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTrigger : MonoBehaviour
{
    public GameObject triggerbox;

    void OnTriggerEnter(Collider other)
    {
        triggerbox.SetActive(false);

    }
}

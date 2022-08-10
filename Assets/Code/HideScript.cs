using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject triggerbox;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("on");
        Destroy(triggerbox);

    }
}

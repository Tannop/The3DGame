using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTargetObj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject triggerbox;
    public GameObject target_obj;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("on");
        target_obj.SetActive(false);

    }
}

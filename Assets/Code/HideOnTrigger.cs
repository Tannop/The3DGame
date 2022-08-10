using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target_obj;
    // Start is called before the first frame update
    void OnCollide()
    {
        Debug.Log("on");
        target_obj.SetActive(false);

    }
}

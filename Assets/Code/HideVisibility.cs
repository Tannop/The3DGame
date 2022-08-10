using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideVisibility : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        if (rend.enabled)
            rend.enabled = false;
    }

}

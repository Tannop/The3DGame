using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class buttonScript : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject number;
    // Start is called before the first frame update
    void Start()
    {
        number = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray,out hit) && hit.collider.gameObject == gameObject)
            {
                NumberCheck.Checknumber(number);
            }
        }
    }
}

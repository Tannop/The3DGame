using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleLevel4 : MonoBehaviour
{
    private bool moving;
    private CharacterController player;
    private Vector3 lastPos;


    public static float idletime;

    // Start is called before the first frame update
    void Start()
    {
        //player = GetComponent<Rigidbody>();
        player = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (player.transform.position != lastPos)
        {

        }
        else
        {
            // We're not moving
            //moving = false;
            idletime += Time.deltaTime;
        }

        lastPos = player.transform.position;

        //Debug.Log(idletime);
    }

}

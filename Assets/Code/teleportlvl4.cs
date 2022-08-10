using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportlvl4 : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform thePlayer;
    public Transform theNPC;

    public static float aitime;
    public static float playertime;
    void OnTriggerEnter(Collider col)
    {

        CharacterController cc = thePlayer.GetComponent<CharacterController>();
        //Debug.Log("Entered");
        cc.enabled = false;
        thePlayer.transform.position = teleportTarget.transform.position;
        theNPC.transform.position = teleportTarget.transform.position;
        cc.enabled = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public Transform thePlayer;
    public Transform theNPC;
    public static int lvl3score;
    public int _lvl3socre = 0;
    public static float aitime;
    public static float playertime;
    void OnTriggerEnter(Collider col)
    {     
        CharacterController cc = thePlayer.GetComponent<CharacterController>();
        //Debug.Log("Entered");
        _lvl3socre++;
        lvl3score = _lvl3socre;
        //Debug.Log("Score = " + lvl3score);
        cc.enabled = false;
        thePlayer.transform.position = teleportTarget.transform.position;
        theNPC.transform.position = teleportTarget.transform.position;
        cc.enabled = true;
    }
}

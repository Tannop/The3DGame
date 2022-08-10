using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCloidor : MonoBehaviour{

    public Dialogue dialogue;
    public GameObject triggerbox;
    bool trigger = true;
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("on");
        if (trigger == true)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            trigger = false;
            //triggerbox.SetActive(false);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("Off");

    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}

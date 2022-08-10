using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogStart : MonoBehaviour
{

    public Dialogue dialogue;
    bool trigger = true;
    private void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
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
        Debug.Log("Off");

    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}

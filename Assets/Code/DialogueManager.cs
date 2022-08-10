using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour {

    public static bool GameIsPaused = false;

    public Text nameText;
	public Text dialogueText;
    public Animator animator;
    private int count = 0;
	private Queue<string> sentences;
    public GameObject Player;
	FirstPersonController playerScript;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
		playerScript = Player.GetComponent<FirstPersonController>();
	}

    public void QueueNewSentence(Dialogue dialogue)
    {
        sentences = new Queue<string>();
    }

	public void StartDialogue (Dialogue dialogue)
	{
        GameIsPaused = true;
        //Pause game
        Time.timeScale = 0f;
		Player.GetComponent<CharacterController>().enabled = false;
		playerScript.MouseSensitivity = 0;
		//Debug.Log("pause Game");//
		animator.SetBool("IsOpen", true);

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
        count = count++;
		if (sentences.Count == 0)
		{
			EndDialogue();

            return;
		}

        string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		//Resume game
		Time.timeScale = 1f;
		Player.GetComponent<CharacterController>().enabled = true;
		playerScript.MouseSensitivity = 3;
		animator.SetBool("IsOpen", false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public string nextScene;
    public float delay;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShowAndHide(delay));
        
        //Debug.Log("Timer Stopped");
    }

    IEnumerator ShowAndHide(float second)
    {
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene(nextScene);
    }
}
    

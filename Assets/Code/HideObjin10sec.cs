using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideObjin10sec : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject targetObject;
    public GameObject targetObject2;
    public float delay;
    public float delay2;
    public string nextScene;
    public void Start()
    {
        targetObject2.SetActive(false);
        StartCoroutine(ShowAndHide(delay));    
    }

    IEnumerator ShowAndHide(float second)
    {
        //Debug.Log("Hide target 2");
        //if(targetObject2.activeSelf == false)
        
            //Debug.Log("Hidden"); 
        //else 
            //Debug.Log("Im fucked");
        
        
        yield return new WaitForSeconds(second);
        //Debug.Log("done");
        targetObject.SetActive(false);
        targetObject2.SetActive(true);
        //Debug.Log("Show target 2");
        StartCoroutine(StartThis(delay2));
    }
    IEnumerator StartThis(float second)
    {
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene(nextScene);
        //Debug.Log("Move Next scene");
    }

}

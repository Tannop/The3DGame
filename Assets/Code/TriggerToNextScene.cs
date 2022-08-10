using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerToNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject triggerbox;
    public string nextScene;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        SceneManager.LoadScene(nextScene);
    }
}

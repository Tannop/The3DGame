using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public string levelToLoad = "Level 1";

    public void Play()
    {
        SceneManager.LoadScene(levelToLoad);
    }
    
    public void Quit()
    {
        Debug.Log("Exctiting....");
        Application.Quit();
    }
}

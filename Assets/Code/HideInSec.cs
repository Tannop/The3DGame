using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideInSec : MonoBehaviour
{
    public GameObject targetObject;
    void Start()
    {
        StartCoroutine(ShowAndHide(10.0f));
    }
    IEnumerator ShowAndHide(float delay)
    {
        targetObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        targetObject.SetActive(false);
    }
}

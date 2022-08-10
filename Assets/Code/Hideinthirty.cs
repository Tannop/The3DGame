using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hideinthirty : MonoBehaviour
{
    public GameObject targetObject;
    void Start()
    {
        StartCoroutine(ShowAndHide(30.0f));
    }
    IEnumerator ShowAndHide(float delay)
    {
        targetObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        targetObject.SetActive(false);
    }
}

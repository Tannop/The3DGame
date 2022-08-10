using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public GameObject moveTarget;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        moveTarget.transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
    public GameObject moveTarget;
    public float speed;
    public Vector3 pos;

    public void Update()
    {
        pos = transform.position;
        float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
        moveTarget.transform.position = new Vector3(0, y, 0);
    }
}

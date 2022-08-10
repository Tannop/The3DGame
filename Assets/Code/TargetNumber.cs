using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetNumber : MonoBehaviour
{
    public int number;
    public static int numbers;
    // Start is called before the first frame update
    private void Start()
    {
        numbers = number;
    }
}

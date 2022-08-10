using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisIsTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameObject[] ThisTarget;
    public  GameObject[] _Targets;

    private void Start()
    {

        ThisTarget = _Targets;
        SetAnswer();
    }
    void SetAnswer()
    {
        for (int i =0;i<_Targets.Length; i++)
        {
            _Targets[i].GetComponent<AnswerScript>().isCorrect = false;
            //_Targets[i].transform.GetChild(0).GetComponent<Text>().text = QmA[current]
        }
    }
}

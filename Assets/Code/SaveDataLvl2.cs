using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataLvl2 : MonoBehaviour
{
    public static int playertime;
    public static int aitime;

    // Start is called before the first frame update
    void Start()
    {

    }
    void update()
    {
        playertime = Mathf.RoundToInt(RandomObjectToTarget.playertime);
        aitime = Mathf.RoundToInt(RandomObjectToTarget.aitime);
    }
}

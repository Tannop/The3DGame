using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savedatalvl1 : MonoBehaviour
{
    public static int lvl1score;
    public static int lvl1totalshot;
    public static int lvl1left;
    public static int lvl1right;
    public static int lvl1total;

    // Start is called before the first frame update
    void Start()
    {
        lvl1score = RayCastShootComplete.finalscore;
        lvl1totalshot = RayCastShootComplete.totalshot/10;
        lvl1left = RayCastShootComplete.left;
        lvl1right = RayCastShootComplete.right;
        lvl1total = RayCastShootComplete.total;
    }
    void Update()
    {
        lvl1score = RayCastShootComplete.finalscore;
        lvl1totalshot = RayCastShootComplete.totalshot/10;
        lvl1left = RayCastShootComplete.left;
        lvl1right = RayCastShootComplete.right;
        lvl1total = RayCastShootComplete.total;
    }
}

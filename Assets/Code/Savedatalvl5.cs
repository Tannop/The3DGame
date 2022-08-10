using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savedatalvl5 : MonoBehaviour
{
    public static int lvl5score;
    public static int lvl5totalshot;
    public static int lvl5left;
    public static int lvl5right;
    public static int lvl5total;

    // Start is called before the first frame update
    void Start()
    {
        lvl5score = RayCastShootComplete.finalscore;
        lvl5totalshot = RayCastShootComplete.totalshot / 10;
        lvl5left = RayCastShootComplete.left;
        lvl5right = RayCastShootComplete.right;
        lvl5total = RayCastShootComplete.total;
    }
    void Update()
    {
        lvl5score = RayCastShootComplete.finalscore;
        lvl5totalshot = RayCastShootComplete.totalshot / 10;
        lvl5left = RayCastShootComplete.left;
        lvl5right = RayCastShootComplete.right;
        lvl5total = RayCastShootComplete.total;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Classifier : MonoBehaviour
{
    public Text congrat;
    public int Language=1;
    public GameObject lab1;
    public GameObject lab2;
    public GameObject lab3;
    public GameObject lab4;
    public GameObject lab5;
    public GameObject lab6;
    public GameObject lab7;
    public GameObject lab8;
    public GameObject lab9;
    public GameObject lab10;
    public GameObject lab11;
    public GameObject lab12;
    public GameObject lab13;
    public GameObject lab14;
    public GameObject lab15;
    public GameObject lab16;
    int testtime = 20;

    // Start is called before the first frame update
    void Start()
    {
        lab1.SetActive(false);
        lab2.SetActive(false);
        lab3.SetActive(false);
        lab4.SetActive(false);
        lab5.SetActive(false);
        lab6.SetActive(false);
        lab7.SetActive(false);
        lab8.SetActive(false);
        lab9.SetActive(false);
        lab10.SetActive(false);
        lab11.SetActive(false);
        lab12.SetActive(false);
        lab13.SetActive(false);
        lab14.SetActive(false);
        lab15.SetActive(false);
        lab16.SetActive(false);

        if (Language ==1)
            perdict1();
        else
            perdict2();
    }

    void perdict1()
    {
        int classify;
        float playeraitime =RandomObjectToTarget.playertime / RandomObjectToTarget.aitime;

        if (IdleLevel4.idletime <= 16.71976)
            if (Savedatalvl5.lvl5score <= 7)
                if (Savedatalvl5.lvl5totalshot <= 8)
                    if (Savedatalvl5.lvl5right <= 4)
                        if (Savedatalvl1.lvl1total <= 5)
                            classify = 4;
                        else
                            classify = 7;
                    else if (Savedatalvl1.lvl1total <= 7)
                        classify = 2;
                    else
                        classify = 5;
                else
                    classify = 8;
            else
                classify = 4;
        else if (Savedatalvl1.lvl1totalshot <= 6)
            if (IdleLevel3.idletime <= 22.52711)
                classify = 6;
            else
                classify = 3;
        else
            classify = 1;

        switch (classify)
        {
            case 1:
                lab9.SetActive(true);
                break;
            case 2:
                lab10.SetActive(true);
                break;
            case 3:
                lab11.SetActive(true);
                break;
            case 4:
                lab12.SetActive(true);
                break;
            case 5:
                lab13.SetActive(true);
                break;
            case 6:
                lab14.SetActive(true);
                break;
            case 7:
                lab15.SetActive(true);
                break;
            case 8:
                lab16.SetActive(true);
                break;
        }
        Debug.Log( classify);
    }
    void perdict2()
    {
        int classify;
        float playeraitime = RandomObjectToTarget.playertime / RandomObjectToTarget.aitime;
        //float playeraitime = 1;

        if (IdleLevel4.idletime <= 16.71976)
            if (Savedatalvl5.lvl5score <= 7)
                if (Savedatalvl5.lvl5totalshot <= 8)
                    if (Savedatalvl5.lvl5right <= 4)
                        if (Savedatalvl1.lvl1total <= 5)
                            classify = 4;
                        else
                            classify = 7;
                    else if (Savedatalvl1.lvl1total <= 7)
                        classify = 2;
                    else
                        classify = 5;
                else
                    classify = 8;
            else
                classify = 4;
        else if (Savedatalvl1.lvl1totalshot <= 6)
            if (IdleLevel3.idletime <= 22.52711)
                classify = 6;
            else
                classify = 3;
        else
            classify = 1;

        switch (classify)
        {
            case 1:
                lab1.SetActive(true);
                break;
            case 2:
                lab2.SetActive(true);
                break;
            case 3:
                lab3.SetActive(true);
                break;
            case 4:
                lab4.SetActive(true);
                break;
            case 5:
                lab5.SetActive(true);
                break;
            case 6:
                lab6.SetActive(true);
                break;
            case 7:
                lab7.SetActive(true);
                break;
            case 8:
                lab8.SetActive(true);
                break;
        }
    }
}

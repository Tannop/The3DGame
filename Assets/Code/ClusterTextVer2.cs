using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class ClusterTextVer2 : MonoBehaviour
{
    // private string[] m_InspectorStrings;
    List<string> _30wordlist = new List<string>();
    List<string> _10CorrectWord = new List<string>();
    List<string> _20WrongWord = new List<string>();

    public TextMesh[] clusterZone1;
    public TextMesh[] clusterZone2;
    public TextMesh[] clusterZone3;
    public TextMesh[] clusterZone4;
    int[] amount_clusterZone = {2,2,3,3};

    public string[] _30words;
    public string[] _10words;
    public string[] _10words_ans;
    public string[] _20words_wans;

    public TextAsset wordList;
    string[] words;
    public TextMesh[] targets;
    public TextMeshPro[] words_board;

    public static string[] _10Backup;
   
    public static string[] _20backup;

     void Start()
    {
        StartCoroutine(ShowAndHide(1));
    }
    void Main()
    {      
        if (wordList != null)
        {
            words = (wordList.text.Split(' '));

            System.Random random = new System.Random();

            // Random 30 words form txt
            for (int i = 0; i < _30words.Length; i++)
            {
                int useWord = random.Next(words.Length);
                string pickWord = words[useWord];

                //Debug.Log(i + 1 + ") 30 Words: " + pickWord);
                //_30wordlist.Add(pickWord);
                //_30words = _30wordlist.ToArray();
                _30words[i] = pickWord;

                RemoveAt(ref words, useWord);
            }
            //Random 10 words from 30 word for correct answer
            for (int i = 0; i < 10; i++)
            {
                int Ans_word = random.Next(_30words.Length);
                string pickWord = _30words[Ans_word];

                //Debug.Log(i + 1 + ") 10 Words: " + pickWord);
                //_10CorrectWord.Add(pickWord);
                //_10words = _10CorrectWord.ToArray();
                _10words[i] = pickWord;

                RemoveAt(ref _30words, Ans_word);
                //_30words from 30 words now have 20 unused words
            }

            
            for (int i =0; i<_10words.Length; i++)
                _10words_ans[i] = _10words[i];

            _10Backup = _10words_ans;

            for (int i = 0; i < _30words.Length; i++)
                _20words_wans[i] = _30words[i];

            _20backup = _20words_wans;

            //Set remain 20 words to lanterns
            for (int i = 0; i < 20; i++)
            {
                targets[i].GetComponent<TextMesh>().text = _30words[i];
                //Debug.Log("Done");
                //Debug.Log( i + " Words: " + _20backup[i]);
            }
            
            // Set 10 words for the board
            for (int i = 0; i < 10; i++)
            {
                words_board[i].GetComponent<TextMeshPro>().text = _10words[i];
                //Debug.Log("Done");
                //Debug.Log( i + " Words: " + _10words[i]);
            }

            int c1 = random.Next(amount_clusterZone.Length);
            int Cluster_1_amount = amount_clusterZone[c1];
            RemoveAt(ref amount_clusterZone, c1);
            //Debug.Log("Cluster_1_amount : " + Cluster_1_amount);

            for (int i = 0; i < Cluster_1_amount; i++)
            {
                int c1_word = random.Next(_10words.Length);
                //Debug.Log(c1_word);
                int c1_location = random.Next(clusterZone1.Length);
                clusterZone1[c1_location].GetComponent<TextMesh>().text = _10words[c1_word];

                //Debug.Log("Word " + c1_location + " : " + _10words[c1_word]);
                RemoveAt(ref _10words, c1_word);
                RemoveAt(ref clusterZone1, c1_location);
            }
           // Debug.Log(_10words.Length);

            //Cluster 2
            int c2 = random.Next(amount_clusterZone.Length);
            int Cluster_2_amount = amount_clusterZone[c2];      
            RemoveAt(ref amount_clusterZone, c2);
           // Debug.Log("Cluster_2_amount : " + Cluster_2_amount);
            for (int i = 0; i < Cluster_2_amount; i++)
            {
                int c2_word = random.Next(_10words.Length);
                int c2_location = random.Next(clusterZone2.Length);
                clusterZone2[c2_location].GetComponent<TextMesh>().text = _10words[c2_word];

                //Debug.Log("Word " + c2_location + " : " + _10words[c2_word]);
                RemoveAt(ref _10words, c2_word);
                RemoveAt(ref clusterZone2, c2_location);
            }
            //Debug.Log(_10words.Length);
            //Cluster 3
            int c3 = random.Next(amount_clusterZone.Length);
            int Cluster_3_amount = amount_clusterZone[c3];
            RemoveAt(ref amount_clusterZone, c3);
            //Debug.Log("Cluster_3_amount : " + Cluster_3_amount);
            for (int i = 0; i < Cluster_3_amount; i++)
            {
                int c3_word = random.Next(_10words.Length);
                int c3_location = random.Next(clusterZone3.Length);
                clusterZone3[c3_location].GetComponent<TextMesh>().text = _10words[c3_word];

               //Debug.Log("Word " + c3_location + " : " + _10words[c3_word]);
                RemoveAt(ref _10words, c3_word);
                RemoveAt(ref clusterZone3, c3_location);
            }
            //Debug.Log(_10words.Length);
            //Cluster 4
            int c4 = random.Next(amount_clusterZone.Length);
            int Cluster_4_amount = amount_clusterZone[c4];
            //Debug.Log("Cluster_4_amount : " + Cluster_4_amount);
            for (int i = 0; i < Cluster_4_amount; i++)
            {
                int c4_word = random.Next(_10words.Length);
                int c4_location = random.Next(clusterZone4.Length);
                clusterZone4[c4_location].GetComponent<TextMesh>().text = _10words[c4_word];

               // Debug.Log("Word " + c4_location + " : " + _10words[c4_word]);
                RemoveAt(ref _10words, c4_word);
                RemoveAt(ref clusterZone4, c4_location);
            }
            //Debug.Log(_10words.Length);
        }
    }

    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        for (int a = index; a < arr.Length - 1; a++)
        {
            // moving elements downwards, to fill the gap at [index]
            arr[a] = arr[a + 1];
        }
        //decrement Array's size by one
        Array.Resize(ref arr, arr.Length - 1);
    }
    IEnumerator ShowAndHide(float second)
    {
        yield return new WaitForSeconds(second);
        Main();
    }

}


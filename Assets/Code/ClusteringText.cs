using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine.UI;

public class ClusteringText : MonoBehaviour
{
    [SerializeField]
    // private string[] m_InspectorStrings;
    List<string> _20wordlist = new List<string>();
    List<string> _10CorrectWord = new List<string>();
    List<string> _10WrongWord = new List<string>();

    string[] _20words;
    string[] _10words;
    string[] _10words_unused;
    string[] _20backup;
    public TextAsset wordList;
    string[] words;
    public TextMesh[] targets;
    public TextMesh[] words_board;
    void Start()
    {
        if (wordList != null)
        {
            words = (wordList.text.Split(' '));
            
            System.Random random = new System.Random();

            // Random 20 words form txt
            for (int i = 0; i < 20; i++)
            {
                int useWord = random.Next(words.Length);
                string pickWord = words[useWord];

                //Debug.Log("20 Words: " + pickWord);
                _20wordlist.Add(pickWord);
                _20words = _20wordlist.ToArray();

                RemoveAt(ref words, useWord);
            }
            //Set 20 words for lantern
            for (int i = 0; i < 20; i++)
            {
                targets[i].GetComponent<TextMesh>().text = _20words[i];
                //Debug.Log("Done");
                //Debug.Log( i + " Words: " + _20backup[i]);
            }
            
            _20backup = _20words;

            //Random 10 words from 20 word for correct answer
            for (int i = 0; i < 10; i++)
            {
                int useWord2 = random.Next(_20words.Length);
                string pickWord = _20words[useWord2];

                //Debug.Log("10 Correct Words: " + pickWord);
                _10CorrectWord.Add(pickWord);
                _10words = _10CorrectWord.ToArray();

                RemoveAt(ref _20words, useWord2);
                //_20words from 20 words now have 10 unused words
            }
            // Set 10 words for the board
            for (int i = 0; i < 10; i++)
            {
                words_board[i].GetComponent<TextMesh>().text = _10words[i];
                //Debug.Log("Done");
                //Debug.Log( i + " Words: " + _10words[i]);
            }
            //Left over words (Wrong answer)

            for (int i = 0; i < 10; i++)
            {
                int useWord3 = random.Next(_20words.Length);
                string pickWord = _20words[useWord3];

                //Debug.Log("10 Wrong Words: " + pickWord);
                _10WrongWord.Add(pickWord);
                _10words_unused = _10WrongWord.ToArray();

                RemoveAt(ref _20words, useWord3);
                //_20words from 20 words now have 10 unused words
            }

          //  Debug.Log("_20words: " + _20words.Length);
           // Debug.Log("_10words: " + _10words.Length);
           // Debug.Log("_10words_unused: " + _10words_unused.Length);
           // Debug.Log("_20backup: " + _20backup.Length);
            
            /*for(int i = 0; i < 10; i++)
            {
                Debug.Log("Answer: " + _10words[i]);
            }
            */
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

    public static void Randon2word()
    {


    }

    private void Update()
    {
        
    }
}

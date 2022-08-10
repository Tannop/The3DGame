using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class Randomwordfromtxt : MonoBehaviour
{
    [SerializeField]
    // private string[] m_InspectorStrings;
    List<string> list = new List<string>();

    string[] _20words;
    string[] _10words;
    string[] _20backup;
    public TextAsset wordList;
    string[] words;

    void Start()
    {
        if (wordList != null)
        {
            words = (wordList.text.Split(' '));

            System.Random random = new System.Random();

            for (int i = 0; i < 20; i++)
            {
                int useWord = random.Next(words.Length);
                string pickWord = words[useWord];

                Debug.Log("20 Words: " + pickWord);
                list.Add(pickWord);
                _20words = list.ToArray();

                RemoveAt(ref words, useWord);
            }
            _20backup = _20words;

            for (int i = 0; i < 10; i++)
            {
                int useWord = random.Next(_20words.Length);
                string pickWord = _20words[useWord];

                Debug.Log("10 Words: " + pickWord);
                list.Add(pickWord);
                _10words = list.ToArray();

                RemoveAt(ref _20words, useWord);
            }

        }
    }

    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        for (int a = index; a < arr.Length - 1; a++)
        {
            // moving elements downwards, to fill the gap at [index]
            arr[a] = arr[a + 1];
        }
        // finally, let's decrement Array's size by one
        Array.Resize(ref arr, arr.Length - 1);
    }

}
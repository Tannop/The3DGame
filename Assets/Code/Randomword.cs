using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

public class Randomword : MonoBehaviour
{
    [SerializeField]
   // private string[] m_InspectorStrings;
    private string[] words;
    List<string> list = new List<string>();
    string[] str;
    

    // Start is called before the first frame update
    void Start()
    {
        words = new string[] { "Accident", "Collect", "Factory", "Nervous", "Reflect", "Yard", "Shelter", "Flap", "Team", "Discard", "Cliff", "Stack", "Float", "Arrive", "Notice", "Wonder", "Safe", "Luxury", "Beach", "Dozen" };
        System.Random random = new System.Random();

        for (int i = 0; i < 20; i++)
        {           
            int useWord = random.Next(words.Length);
            string pickWord = words[useWord];
                
            Debug.Log(pickWord);
            list.Add(pickWord);
            str = list.ToArray();

            RemoveAt(ref words, useWord);
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

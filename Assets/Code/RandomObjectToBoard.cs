using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectToBoard : MonoBehaviour
{
    string[] number = new string[] { "1", "2", "3", "4", "5", "6", "7", "8"};
    List<string> numbers = new List<string>();
    List<GameObject> icons = new List<GameObject>();
    public string[] thenumber;
    GameObject[] theicon;

    public static string[] _thenumber;
    public static GameObject[] _theicon;
 
    public GameObject newicon;
    //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public TextMesh[] number_board;
    public GameObject[] icon_board;
    //public GameObject iconanswerboard;
    public GameObject[] icon;
    
    private GameObject[] _icons;
    public TextMesh[] number_floor;
    public GameObject locationAnswer;
    private Vector3 SpawnPosition;
    public int targeticon;
    public GameObject ObjectToCreate;
    public GameObject triggerbox;
    public static Vector3 targetposition;
    public static int lvl4score;
    public int _lvl4score = 0;

    void Start()
    {
        //_icons = icon;
        randomNumber();
        //SetBoardIcon();
    }

    void OnTriggerEnter(Collider answer_portal)
    {        
        //SetBoardIcon();
        Destroy(newicon);
        Destroy(triggerbox);
        //Debug.Log("Done");
        _lvl4score++;
        lvl4score = _lvl4score;
        //Debug.Log("Score = " + _lvl4score);
        System.Random random = new System.Random();
        //Random answer location

        targeticon = random.Next(_theicon.Length);
        GameObject answericon = _theicon[targeticon];

        int targeticonnumber = System.Convert.ToInt32(_thenumber[targeticon]);
        ///Debug.Log("This is the icon number " + targeticonnumber);

        SpawnPosition = number_floor[targeticonnumber - 1].GetComponent<TextMesh>().transform.position;
        //  SpawnPosition     
        targetposition = SpawnPosition;
        //Debug.Log("targetposition"+ targetposition);
        //
        newicon = Instantiate(_theicon[targeticon], locationAnswer.transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;

        GameObject answer_portal2 = Instantiate(ObjectToCreate, new Vector3(SpawnPosition.x, SpawnPosition.y + 1.5f, SpawnPosition.z), Quaternion.Euler(0, 0, 0));

        ///Debug.Log("Spawn answer on tile : " + (targeticonnumber));
        
    }

    // Choose 1 icon for answer

    private void randomNumber()
    {
        System.Random random = new System.Random();
        // Choose number and icon for each location
        
        for (int i = 0; i < 8; i++)
        {
            int _number = random.Next(number.Length);
            int _number2 = random.Next(number.Length);
            string picknumber = number[_number];
            GameObject pickicon = icon[_number2];

            numbers.Add(picknumber);
            thenumber = numbers.ToArray();


            icons.Add(pickicon);
            theicon = icons.ToArray();

            RemoveAt(ref number, _number);
            RemoveAt(ref icon, _number2);
        }
        //Set Number and icon to board

        for (int i = 0; i < 8; i++)
        {
            int randomnumber = random.Next(number.Length);
            number_board[i].GetComponent<TextMesh>().text = thenumber[i];
            GameObject newObject = Instantiate(theicon[i], icon_board[i].transform.position, Quaternion.Euler(0, -90, 0)) as GameObject;
            //Debug.Log("Done");
        }
        _thenumber = thenumber;
        _theicon = theicon;

    }

    public static void RemoveAt<T>(ref T[] arr, int index)
    {
        for (int a = index; a < arr.Length - 1; a++)
        {
            // moving elements downwards, to fill the gap at [index]
            arr[a] = arr[a + 1];
        }
        // finally, let's decrement Array's size by one
        System.Array.Resize(ref arr, arr.Length - 1);
    }   


    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class RandomObjectToTarget : MonoBehaviour
{
    private Transform _destination;
    public  Vector3[] destinations;
    Vector3 current;
    public AudioSource playSound;

    NavMeshAgent _navMeshAgent;
    public int totalnumber;
    public GameObject[] spawnObject;
    public GameObject[] spawnPosition;
    public List<GameObject> generatedObjectinhere;
    public static List<GameObject> generatedObject;
    private int ii = 0;
    public int scale = 0;
    public int counterforlvl2=0;
    public string nextScene = "Level 3";

    public static float aitime = 0;
    private bool pauseaiTimer = false;

    public static float playertime = 0;
    private bool pauseplayerTimer = false;
    

    // Start is called before the first frame update
    void Awake()
    {
        //https://answers.unity.com/questions/578209/choosing-a-random-location-out-of-a-list-for-an-ob.html 
        //spawn random object at random location

        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        for (int i = 0;i< spawnObject.Length; i++)
         { 
            int spawnPositionIndex = Random.Range(0, spawnPosition.Length); // or Count can't remember right, anyway the length of the array list
            //Debug.Log("Location  =" + spawnPositionIndex);
            //Debug.Log("Position size  =" + spawnPosition.Length);
            GameObject newObject = Instantiate(spawnObject[i], spawnPosition[spawnPositionIndex].transform.position, spawnPosition[spawnPositionIndex].transform.rotation);
            newObject.transform.localScale = new Vector3(scale*100, scale * 100, scale * 100);
            generatedObjectinhere.Add(newObject);

            destinations[i] = spawnPosition[spawnPositionIndex].transform.position;
            generatedObject = generatedObjectinhere;
            //RemoveAt(ref spawnObject, i);
            RemoveAt(ref spawnPosition, spawnPositionIndex);

        }

        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent componet is not attached to " + gameObject.name);
        }
        else
        {
            _navMeshAgent = this.GetComponent<NavMeshAgent>();
            _navMeshAgent.destination = destinations[ii];
        }
    }

    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        if (!pauseaiTimer)
            aitime += Time.deltaTime;
        if (!pauseplayerTimer)
            playertime += Time.deltaTime;


        var dist = Vector3.Distance(destinations[ii], transform.position);
        current = destinations[ii];
        //if npc reaches its destination...
        //if npc reaches its destination (or gets close)...
        if (dist < 1)
        {
            if (ii < destinations.Length - 1)
            { //negate targets[0], since it's already set in destination.
                ii++; //change next target
                _navMeshAgent.destination = destinations[ii]; //go to next target by setting it as the new destination
                //Debug.Log(i);
            }
            else
            {
                StopaiTimer();
                //Debug.Log("reached the end");
                //Debug.Log("Ai time used = "+ aitime); 
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
        //decrement Array's size by one
        System.Array.Resize(ref arr, arr.Length - 1);
    }
    
    private void SetDestination()
    {
        if (_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
        
    }
    public void Trigger(GameObject gameObject)
    {
            //Debug.Log(counterforlvl2);
            if (generatedObject.Contains(gameObject))
                if (gameObject == generatedObject[counterforlvl2])
                {
                    // Debug Message
                    //Debug.Log("Pickup Collected");
                    // >> Your Pickup Code Here <<


                    playSound.Play();
                    gameObject.SetActive(false);
                    counterforlvl2++;
                    //Debug.Log(counterforlvl2);
                }
                else
                {
                    // Debug Message
                    //Debug.Log("Wrong order");
                }

            if (counterforlvl2 == totalnumber)
                SceneManager.LoadScene(nextScene);           
                //Debug.Log("Not complete");
        }
    

    public void StopaiTimer()
    {
        pauseaiTimer = true;

        //Debug.Log("Timer Stopped");
    }

    public void StopplayerTimer()
    {
        pauseplayerTimer = true;

        //Debug.Log("Timer Stopped");
    }



}

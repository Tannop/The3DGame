using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npc_Move_LVL3 : MonoBehaviour
{
    public Vector3 destinations;
    Vector3 current;

    NavMeshAgent _navMeshAgent;

    public static float aitime = 0;
    private bool pauseaiTimer = false;

    public static float playertime = 0;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        destinations = RandomWordFloor.targetposition;
//Debug.Log(destinations);
        if (_navMeshAgent == null)
        {
            Debug.LogError("The nav mesh agent componet is not attached to " + gameObject.name);
        }
        else
        {
            _navMeshAgent.destination = destinations;
        }
    }

    // Update is called once per frame
    void Update()
    {
        destinations = RandomWordFloor.targetposition;
        //Debug.Log(destinations);

        if (!pauseaiTimer)
            aitime += Time.deltaTime;

        var dist = Vector3.Distance(destinations, transform.position);

        //if npc reaches its destination...
        //if npc reaches its destination (or gets close)...
        if (dist > 1)
        {
            StartaiTimer();
            _navMeshAgent.destination = destinations;          
        }
        else
        {
            StopaiTimer();
            //Debug.Log("reached the end");
            //Debug.Log("Ai time used = " + aitime);
        }
    }

    public void StopaiTimer()
    {
        pauseaiTimer = true;

        //Debug.Log("Timer Stopped");
    }
    public void StartaiTimer()
    {
        pauseaiTimer = false;

        //Debug.Log("Timer Started");
    }
}

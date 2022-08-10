using UnityEngine;
using System.Collections.Generic;

public class TargetHandler : MonoBehaviour
{
    // Public References
    public List<GameObject> targetCache; // Add Target Objects In Inspector

    // --
    private void Start()
    {
        Debug.Log("Runned");
        //  RandomObjectToTarget.spawnedNumber
    }
    public void OnTriggerEnter(Collider col)
    {
        // Identify Collision Object
        if (targetCache.Contains(col.gameObject))
        {
            if (targetCache.IndexOf(col.gameObject) == 0)
            {
                // Debug Message
                Debug.Log("Pickup Collected");
                // Remove Target Object From List
                targetCache.RemoveAt(0);
                // >> Your Pickup Code Here <<
            }
            else
            {
                // Debug Message
                Debug.Log("Wrong order");
                // Your Eliminate Player Code Here <<
            }
        }
    }
}
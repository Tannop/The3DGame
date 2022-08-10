using UnityEngine;
using System.Collections;

public class RayCastShootComplete : MonoBehaviour {

	public int gunDamage = 1;											// Set the number of hitpoints that this gun will take away from shot objects with a health script
	public float fireRate = 0.25f;										// Number in seconds which controls how often the player can fire
	public float weaponRange = 50f;										// Distance in Unity units over which the player can fire
	public float hitForce = 100f;										// Amount of force which will be added to objects with a rigidbody shot by the player
	public Transform gunEnd;											// Holds a reference to the gun end object, marking the muzzle location of the gun

	private Camera fpsCam;												// Holds a reference to the first person camera
	private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);	// WaitForSeconds object used by our ShotEffect coroutine, determines time laser line will remain visible
	private AudioSource gunAudio;										// Reference to the audio source which will play our shooting sound effect
	private LineRenderer laserLine;										// Reference to the LineRenderer component which will display our laserline
	private float nextFire;												// Float to store the time the player will be allowed to fire again, after firing
    public static int finalscore;
    public static int totalshot;
    public static int left;
    public static int right;
    public static int total;

    private int scoretemp=0;
    private int shottemp = 0;
    private int current_shot;
    private int temp_total;
    private int previous_shot;
    private int temp_left;
    private int temp_right;

    //private string shot = null;

    void Start () 
	{
		// Get and store a reference to our LineRenderer component
		laserLine = GetComponent<LineRenderer>();

		// Get and store a reference to our AudioSource component
		gunAudio = GetComponent<AudioSource>();
    
		// Get and store a reference to our Camera by searching this GameObject and its parents
		fpsCam = GetComponentInParent<Camera>();
	}


    void Update()
    {
        // Check if the player has pressed the fire button and if enough time has elapsed since they last fired
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            // Update the time when our player can fire next
            nextFire = Time.time + fireRate; 

            // Start our ShotEffect coroutine to turn our laser line on and off
            StartCoroutine(ShotEffect());

            // Create a vector at the center of our camera's viewport
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));

            // Declare a raycast hit to store information about what our raycast has hit
            RaycastHit hit;

            // Set the start position for our visual effect for our laser to the position of gunEnd
            laserLine.SetPosition(0, gunEnd.position);

            // Check if our raycast has hit anything
            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
            {
                    // Set the end position for our laser line 
                    laserLine.SetPosition(1, hit.point);

                    // Get a reference to a health script attached to the collider we hit
                    ShootableBox health = hit.collider.GetComponent<ShootableBox>();
                    
                    // If there was a health script attached
                    if (health != null)
                    {
                        // Call the damage function of that script, passing in our gunDamage variable
                        health.Damage(gunDamage);
                    }

                    // Check if the object we hit has a rigidbody attached
                    if (hit.rigidbody != null)
                    {
                        // Add force to the rigidbody we hit, in the direction from which it was hit
                        hit.rigidbody.AddForce(-hit.normal * hitForce);
                    }
                //Add score for correct target 
                //Set target
                
                previous_shot = current_shot;
                foreach (string x in ClusterTextVer2._10Backup)
                {
                    if (hit.collider.GetComponent<TextMesh>()!=null)
                    if (x.Equals(hit.collider.GetComponent<TextMesh>().text))
                    {
                        //Debug.Log("Correct!");
                        scoretemp++;
                        shottemp++;
                        int shot = System.Array.IndexOf(ClusterTextVer2._10Backup, x);
                        //Debug.Log("Item number in list: "+shot);
                    }
                    else
                    {
                        //Debug.Log("Wrong!");
                        shottemp++;
                    }
                }
                if(hit.collider.GetComponent<TargetNumber>()!=null)
                current_shot = hit.collider.GetComponent<TargetNumber>().number;
                //Debug.Log("Previous shot = " + current_shot);

                int leftright = current_shot - previous_shot;
                if (leftright < -10)
                {
                    temp_left++;
                    //Debug.Log("temp_left = " + temp_left);
                }
                else
                {
                    if (leftright > 0)
                    {
                        temp_left++;
                        //Debug.Log("temp_left = " + temp_left);
                    }
                    if (leftright < 0)
                    {
                        temp_right++;
                        //Debug.Log("temp_right = " + temp_right);
                    }
                }
                temp_total = temp_left - temp_right;
                //Debug.Log(total);


                //ClusterCheck

                //previous_shot = ( hit.collider.gameObject.tag);

                //Positive = Right
                //Negative = Left
                //Random > 0 = Player shot backward



                //Debug.Log("temp_leftright :"+temp_leftright);
                //Debug.Log("temp_random :"+temp_random);

            }
            else
                {
                    // If we did not hit anything, set the end of the line to a position directly in front of the camera at the distance of weaponRange
                    laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
                    
                }
            finalscore = scoretemp;
            totalshot = shottemp;
            left = temp_left;
            right = temp_right;
            total = temp_total;
             //Debug.Log("Finalscore =" + scoretemp);
            //Debug.Log("totalshot =" + shottemp / 10);
        }
    

    }
    



    private IEnumerator ShotEffect()
	{
		// Play the shooting sound effect
		gunAudio.Play ();

		// Turn on our line renderer
		laserLine.enabled = true;

		//Wait for .07 seconds
		yield return shotDuration;

		// Deactivate our line renderer after waiting
		laserLine.enabled = false;
	}
}

/*switch (hit.collider.gameObject.tag)
               {
                   case "Cluster1":
                       switch (previous_shot)
                       {
                           case "Cluster1":
                               //Debug.Log("Same spot!");
                               temp_leftright++;
                               break;
                           case "Cluster2":
                               //Debug.Log("Right!");
                               temp_leftright++;
                               break;
                           case "Cluster3":
                               //Debug.Log("Behind!");
                               temp_random++;
                               break;
                           case "Cluster4":
                               //Debug.Log("Left!");
                               temp_leftright--;
                               break;
                           case null:
                               break;
                           default:
                               break;
                       }
                       break;
                   case "Cluster2":
                       switch (previous_shot)
                       {
                           case "Cluster1":
                               //Debug.Log("Left!");
                               temp_leftright--;
                               break;
                           case "Cluster2":
                               //Debug.Log("Same spot!");
                               temp_leftright++;
                               break;
                           case "Cluster3":
                               //Debug.Log("Right!");
                               temp_leftright++;
                               break;
                           case "Cluster4":
                               //Debug.Log("Behind!");
                               temp_random++;
                               break;
                           case null:
                               break;
                           default:
                               break;
                       }
                       break;
                   case "Cluster3":
                       switch (previous_shot)
                       {
                           case "Cluster1":
                               //Debug.Log("Behind!");
                               temp_random++;
                               break;
                           case "Cluster2":
                               //Debug.Log("Left!");
                               temp_leftright--;
                               break;
                           case "Cluster3":
                               //Debug.Log("Same spot!");   
                               temp_leftright++;
                               break;
                           case "Cluster4":
                               //Debug.Log("Right!");
                               temp_leftright++;
                               break;
                           case null:
                               break;
                           default:
                               break;
                       }
                       break;
                   case "Cluster4":
                       switch (previous_shot)
                       {
                           case "Cluster1":
                               //Debug.Log("Right!");
                               temp_leftright++;
                               break;
                           case "Cluster2":
                               //Debug.Log("Behind!");
                               temp_random++;
                               break;
                           case "Cluster3":
                               //Debug.Log("Left!");
                               temp_leftright--;
                               break;
                           case "Cluster4":
                               //Debug.Log("Same spot!"); 
                               temp_leftright++;
                               break;
                           case null:
                               break;
                           default:
                               break;
                       }
                       break;
               }*/

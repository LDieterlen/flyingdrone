using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    public static float speed = 0f;
    float WPradius = 1;
  



    // Use this for initialization
    void Start () {
   

    }
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {

            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
            Vector3 relativePos = waypoints[current].transform.position - transform.position;        
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            transform.rotation = rotation;
          

        }


        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        



  



    }
}

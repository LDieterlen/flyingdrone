using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altitude : MonoBehaviour {
    public Collider terrain;
 
    public GameObject cube;
    private int countWayPoints;
    private int i=3;
    public GameObject[] waypoints;
    private bool allowPoint;
    private Vector3 tempPosition;


    // Use this for initialization
    void Start () {
    
        terrain =GetComponent<Collider>();
        countWayPoints = 7;
        allowPoint = true;
    }
	
	// Update is called once per frame
	void Update () {


      
         if (Input.GetMouseButtonDown(0))
         {

            if (allowPoint)
            {
                if (i < 7)
                {
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (terrain.Raycast(ray, out hit, Mathf.Infinity))
                    {

                     
                        tempPosition = hit.point;                    
                        waypoints[i].transform.position = tempPosition;                
                        StartCoroutine(Timer());

                    }
                }
                if (i >= 6)
                {
                    allowPoint = false;
                }
            }
        }
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.4f);
        i++;
      
    }

  }

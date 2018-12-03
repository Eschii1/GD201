using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1MoveNew : MonoBehaviour {


    public float startingPoint;
    public GameObject Player;
    public bool playerDied;
    public GameObject trapDoor;
    public HealthB health;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().useGravity = true;
    }
	
	// Update is called once per frame
	void Update () {


        if (transform.position.y < 4f)
        {

            transform.position = new Vector3(-8, 20, -8);
            health.health -= 20f;
            print("HP Down");
            Debug.Log("HP UP: " + health.health);

            //playerDied = true;

            //Debug.Log("Player has died");
            //Destroy(this.gameObject);

        }


        

        /*
        if (Input.GetKeyDown(KeyCode.W) && transform.position.z < 2f)
        {
            Debug.Log("player pressed w key");
            transform.position += transform.forward * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -8f)
        {
            Debug.Log("player pressed a key");
            transform.position += -transform.right * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.S) && transform.position.z > -8f)
        {
            Debug.Log("player pressed s key");
            transform.position += -transform.forward * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 4f)
        {
            Debug.Log("player pressed d key");
            transform.position += transform.right * gridSize;
        }
        */


        
       /*  
        if(Input.GetAxis("Horizontal")
        {
            move p1
        }
        */
         

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 50, 0f, Input.GetAxis("Vertical") * Time.deltaTime * 50 );
        

        
    }



}

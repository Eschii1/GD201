using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Move : MonoBehaviour {
public float gridSize = 2f;
    public float startingPoint;
    public GameObject P1;
    public bool playerDied;
    public GameObject trapDoor;
    // Use this for initialization
    void Start () {

        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().useGravity = true;
        
    }
    
    // Update is called once per frame
    void Update () {

        //playerDied = false;



        if(Input.GetKeyDown(KeyCode.W) && transform.position.z < 2f){
            Debug.Log("player pressed w key");
            transform.position += transform.forward * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -8f) {
            Debug.Log("player pressed a key");
            transform.position += -transform.right * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.S) && transform.position.z > -8f) {
            Debug.Log("player pressed s key");
            transform.position += -transform.forward * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 4f){
            Debug.Log("player pressed d key");
            transform.position += transform.right * gridSize;
        }


        





        if (transform.position.y < 4f)
        {

            transform.position = new Vector3(-8, 6, -8);
            //playerDied = true;


            //Debug.Log("Player has died");
            //Destroy(this.gameObject);


        }
        /*
        if(playerDied == true)
        {
            Instantiate(P1);
            //P1.transform.position = new Vector3(-8, 6, -8);
        }
        */
    }
}


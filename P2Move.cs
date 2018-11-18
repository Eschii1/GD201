using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Move : MonoBehaviour
{
    public float gridSize = 2f;
    public float startingPoint;
    public GameObject P1;
    public bool playerDied;
    public GameObject trapDoor;
    // Use this for initialization
    void Start()
    {

        GetComponent<Rigidbody>().freezeRotation = true;
        GetComponent<Rigidbody>().useGravity = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.z < 2f)
        {
            Debug.Log("player pressed Up Arrow key");
            transform.position += transform.forward * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -8f)
        {
            Debug.Log("player pressed Left Arrow key");
            transform.position += -transform.right * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z > -8f)
        {
            Debug.Log("player pressed Down Arrow key");
            transform.position += -transform.forward * gridSize;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 4f)
        {
            Debug.Log("player pressed Right Arrow key");
            transform.position += transform.right * gridSize;
        }




        if (transform.position.y < 4f)
        {

            transform.position = new Vector3(4, 6, 2);
            //playerDied = true;


            //Debug.Log("Player has died");
            //Destroy(this.gameObject);


        }
    }
}

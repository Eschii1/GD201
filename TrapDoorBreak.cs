using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorBreak : MonoBehaviour {


    public Transform door;

    public Vector3 readyTrap = new Vector3(-2f, 5.127f, -4f);
    public Vector3 set = new Vector3 (-2f, -5f, -4f);

    public float fallSpeed = 20;

    public bool activated = false;
    public bool frozen = false;



    private void Start()
    {
        
    }


    // Use this for initialization
    void Update ()
    {
        if(activated && !frozen)
        {
            door.position = Vector3.Lerp(door.position, set, Time.deltaTime * fallSpeed);
        }
        else
        {
            door.position = Vector3.Lerp(door.position, readyTrap, Time.deltaTime * fallSpeed);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {
            activateTrap();
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
           setTrap();
        }
    }

    public void setTrap()
    {
        activated = false;
    }

    public void activateTrap()
    {
        activated = true;
    }

	// Update is called once per frame
	
}

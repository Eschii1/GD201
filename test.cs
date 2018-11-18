using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Transform door;

    public Vector3 readyTrap = new Vector3(-2f, 7f, -4f);
    public Vector3 set = new Vector3(-2f, 10f, -4f);

    public float fallSpeed = 5;

    public bool activated = false;

    // Use this for initialization
    void Update()
    {
        if (activated)
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

        if (other.tag == "Player")
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

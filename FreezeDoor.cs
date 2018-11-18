using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeDoor : MonoBehaviour
{
    public Transform door;
    public Vector3 readyTrap = new Vector3(-2f, 5.1f, -4f);
    public bool frozen = false;


    private void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {

            freeze(other);
            
        }
    }

    public void freeze(Collider player)
    {
        frozen = true;

        Debug.Log("Trap is frozen");

        door.GetComponent<TrapDoorBreak>().frozen = true;

        //action.door.position = readyTrap;

        //door.position = readyTrap;

        Destroy(gameObject);
    }


}

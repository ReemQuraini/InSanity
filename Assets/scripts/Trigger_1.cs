using UnityEngine;
using System.Collections;

public class Trigger_1 : MonoBehaviour {

	public DoorScript door;
	// Use this for initialization


	public void unlockDoor()
	{
		door.isLocked = false;


	}


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") ) 
		{
			unlockDoor ();
		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player") ) 
		{
			Destroy(gameObject);
		}

	}

}

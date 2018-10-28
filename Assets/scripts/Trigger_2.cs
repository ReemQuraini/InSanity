using UnityEngine;
using System.Collections;

public class Trigger_2 : MonoBehaviour {

	public GameObject room;
	public DoorScript door;
	//public GameObject trigger;
	//public GameObject cell;

	// Use this for initialization
	public void unlockDoor()
	{
		door.isLocked = false;


	}

	void OnTriggerEnter(Collider other)
	{

		if (other.CompareTag ("Player")) 
		{
			room.SetActive (true);
			unlockDoor ();
			//trigger.SetActive (true);
			//cell.SetActive (true);

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

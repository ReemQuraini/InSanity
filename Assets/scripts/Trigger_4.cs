using UnityEngine;
using System.Collections;

public class Trigger_4 : MonoBehaviour {

	private int count;
	public AudioSource audioSource;
	public AudioClip scream;
	public DoorScript door;
	public GameObject kitchen;
	public GameObject trigger;

	public void unlockDoor()
	{
		door.isLocked = false;


	}
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag ("Player") ) 
		{
			audioSource.PlayOneShot (scream);
			unlockDoor ();
			kitchen.SetActive (false);
			trigger.SetActive (true);
			StartCoroutine ("WaitForSelfDestruct");

		}

	}

	IEnumerator WaitForSelfDestruct ()
	{

		yield return new WaitForSeconds (scream.length);
		Destroy (gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class Trigger_5 : MonoBehaviour {



	public AudioSource audioSource;
	public AudioClip tv;
	public GameObject TV;
	public GameObject trigger;
	//public DoorScript door;



	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") ) 
		{
			audioSource.PlayOneShot (tv);
			TV.SetActive (true);
			trigger.SetActive (true);

			StartCoroutine ("WaitForSelfDestruct");

		}

	}

	IEnumerator WaitForSelfDestruct ()
	{

		yield return new WaitForSeconds (tv.length);
		Destroy (gameObject);
	}
}

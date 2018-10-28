using UnityEngine;
using System.Collections;

public class Pills : MonoBehaviour {

	public GameObject Trigger;
	// Use this for initialization

	public AudioSource audioSource;
	public AudioClip pickUpSound;


	public void Place()
	{
		Trigger.SetActive (true);
		audioSource.PlayOneShot (pickUpSound);

		StartCoroutine ("WaitForSelfDestruct");

	}

	IEnumerator WaitForSelfDestruct ()
	{

		yield return new WaitForSeconds (pickUpSound.length);
		Destroy (gameObject);
	}

}

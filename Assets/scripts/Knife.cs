using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour {

	public GameObject Trigger;
	public GameObject Trigger2;
	public GameObject Trigger3;
	public GameObject Trigger4;
	public GameObject mom;
	// Use this for initialization

	public AudioSource audioSource;
	public AudioClip pickUpSound;


	public void Place()
	{
		Trigger.SetActive (true);
		Trigger4.SetActive (true);
		mom.SetActive (true);
		Destroy(Trigger2);
		Destroy(Trigger3);
		audioSource.PlayOneShot (pickUpSound);

		StartCoroutine ("WaitForSelfDestruct");

	}

	IEnumerator WaitForSelfDestruct ()
	{

		yield return new WaitForSeconds (pickUpSound.length);
		Destroy (gameObject);
	}
}

using UnityEngine;
using System.Collections;

public class Trigger_6 : MonoBehaviour {
	public GameObject bedroom;
	public GameObject cradle;
	public AudioSource audioSource;
	public AudioClip babyCry;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player") ) 
		{
			audioSource.PlayOneShot (babyCry);
			bedroom.SetActive (false);
			cradle.SetActive (true);

			StartCoroutine ("WaitForSelfDestruct");

		}

	}

	IEnumerator WaitForSelfDestruct ()
	{

		yield return new WaitForSeconds (babyCry.length);
		Destroy (gameObject);
	}
}

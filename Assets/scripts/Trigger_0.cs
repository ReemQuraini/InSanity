using UnityEngine;
using System.Collections;

public class Trigger_0 : MonoBehaviour {

	public GameObject furniture;
	public GameObject Trigger;
	// Use this for initialization
	//MeshRenderer render = furniture.GetComponentInChildren<MeshRenderer>();

	void OnTriggerEnter(Collider other)
	{
		
		if (other.CompareTag ("Player")) 
		{
			furniture.SetActive (false);

			Trigger.SetActive (true);

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



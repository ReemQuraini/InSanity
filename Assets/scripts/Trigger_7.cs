using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Trigger_7 : MonoBehaviour {


	public Light spotLight;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) 
		{
			spotLight.enabled = true;
			RenderSettings.ambientIntensity = 0.23f;
		}
	}
}

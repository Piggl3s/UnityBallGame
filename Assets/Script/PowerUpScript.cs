using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour {

public GameObject Particle;
	// Use this for initialization
	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {
				
	}


	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			Instantiate(Particle, transform.position,Quaternion.identity);
			Destroy(gameObject);

		}
	}	

}

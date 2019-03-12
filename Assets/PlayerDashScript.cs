using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDashScript : MonoBehaviour {


	[Tooltip("This is the speed at which the dash will happen")]
	public float dashSpeed = 500;

	public float dashLength = 15;

	private float tick = 0;

	private Vector3 originalVelocity;

	private bool isDashActive = false;
	// Use this for initialization
	void Start () {
		originalVelocity = GetComponent<Rigidbody>().velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

/// <summary>
/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
/// </summary>
		void FixedUpdate()
		{
			if (Input.GetButtonDown("Dash"))
			{
				
				if (!isDashActive) ActivateDash();
			}
		}

		private void ActivateDash()
		{
			tick += Time.timeScale * (Time.deltaTime);
			GetComponent<Rigidbody>().velocity = transform.forward * dashSpeed;
			if (tick > dashLength)
			{
				 isDashActive = false;
				 GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
				 tick = 0;
			}			
		}
}


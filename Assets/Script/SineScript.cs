using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineScript : MonoBehaviour {

	private float speed = 0;

	public bool Centered;

	[Tooltip("Rigidbody must be attached and not kinemetic")]
	public float SpeedIncrease = 0.1f;
	public bool isSwitch = true;

[Tooltip("X,Y,Z")]
	public string Axis = "z"; 

	public float RotateSpeed;

	[Tooltip("Speed in which the ship will change direction")]
	public float TurnSpeed = 3;
	// Use this for initialization
	void Start () {

if (Centered)
{
	if (isSwitch)
	{
		 speed = (TurnSpeed * -1 ) / 1.5f;
	}
	else
	{
		speed = (TurnSpeed) / 1.5f;
	}
}
	}
	
	// Update is called once per frame
	void Update () {
				if (isSwitch)
		{
			speed += SpeedIncrease;
		}
		else
		{
			speed -= SpeedIncrease;
		}

		if (speed > TurnSpeed)
		{
			isSwitch = false;
		}

		if (speed < TurnSpeed * -1)
		{
			isSwitch = true;
		}
	}

	void FixedUpdate()
	{
		switch (Axis.ToUpper())
		{
			case "X": 
				transform.Rotate(RotateSpeed,0,0);
				GetComponent<Rigidbody>().velocity = new Vector3(speed,0,0);
				break;
			case "Y": 
				transform.Rotate(0,RotateSpeed,0);
				GetComponent<Rigidbody>().velocity = new Vector3(0,speed,0);
				break;
			case "Z": 
				transform.Rotate(0,0,RotateSpeed);
				GetComponent<Rigidbody>().velocity = new Vector3(0,0,speed);
				break;		
			}

	
	}
}

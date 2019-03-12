using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

	public float XSpeed = 0.5f;
	public float YSpeed = 0.5f;

	public float XDist = 1;
	public float YDist = 1;

	public int ShakeTime = 10;
	public bool ScreenShakeOn = false;


	private float X = 0;
	private float Y = 0;

	private float tick = 0;
	// Use this for initialization

	private bool switchposY;

	private bool switchposX;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			transform.position = new Vector3(X,Y,-10);
			if (ScreenShakeOn)
			{
				shake();
			}
			else
			{
				X = 0;
				Y = 0;
			}

	}

	public void shake()
	{
		tick ++;
		   
		   if (tick > ShakeTime)
		   {
			   ScreenShakeOn = false;
			   tick = 0;
		   }
		
			if(switchposX)X+= XSpeed;
			else X-= XSpeed;	
			if (X > XDist)switchposX = false;
			if (X < XDist * -1)switchposX = true;

			if(switchposY)Y+=YSpeed;
			else Y -= YSpeed ;	
			if (Y > YDist)switchposY = false;
			if (Y < YDist * -1)switchposY = true;
	}
}

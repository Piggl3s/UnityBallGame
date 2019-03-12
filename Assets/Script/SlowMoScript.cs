using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMoScript : MonoBehaviour {

	private float gameTime = 0.5f;

	private float slowMoLength = 5f;

	private bool slowMoActive = false;

	private float originalTime;

	private float tick = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if (slowMoActive)
			{	
				Time.timeScale = gameTime;
				tick++;
			}

			if (tick > slowMoLength)
			{
				slowMoActive = false;
				tick = 0;	
				Time.timeScale = originalTime;
			}
	
		}

	public void activateSlowMo(int time, float speed)
	{
		gameTime = speed;
		slowMoLength = time;
		slowMoActive = true;	
		originalTime = Time.timeScale;	
	}
	
}

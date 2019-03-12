using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour {

private float tick;
public int CurrentTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tick += 1 * Time.timeScale;
		if (tick > 60)
		{
			CurrentTime++;			
			tick = 0;
		}
		GetComponent<UnityEngine.UI.Text>().text = CurrentTime.ToString();

	}
}

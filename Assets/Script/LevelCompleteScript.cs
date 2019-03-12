using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteScript : MonoBehaviour {

public int UIDelay = 30;
private int tick = 0;

public bool isLevelComplete = false;
//public int SceneToLoad;

public int GoldThreshold = 5;
public int SilverThreshold = 5;

public GameObject GoldObj;

public GameObject SilverObj;

public GameObject BronzeObj;

public string endOfLevelText;
private bool isUIshown = false; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		try{
		GameObject.Find("EndLevelText").GetComponent<UnityEngine.UI.Text>().text = endOfLevelText;
		} catch {};

		if (isLevelComplete)
		{
			EndOfLevel();
		}
	}

	void OnCollisionEnter (Collision col)
	{


	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider col)
	{
				if (col.gameObject.tag == "Player")
		{
			isLevelComplete = true;
			GameObject.FindGameObjectWithTag("Lid").GetComponent<Rigidbody>().useGravity = true;
			if (!isUIshown)ShowMedal();	
		}
	}


	//write all the end of level stuff in this function...love paul from the past
	private void EndOfLevel()
	{
		tick ++;
		if (tick > UIDelay)
		{
			GameObject.Find("CompleteCanvas").GetComponent<Canvas>().enabled = true;
			
		}


		
		
		//SceneManager.LoadScene(SceneToLoad);
	}

	private void ShowMedal()
	{
		int currentTime = GameObject.FindGameObjectWithTag("LevelTime").GetComponent<TimerScript>().CurrentTime;
		
		try{
		
		

		if (currentTime <= GoldThreshold)
		{
			Instantiate(GoldObj,new Vector3(0,0,0),Quaternion.identity);
	    }

		if (currentTime > GoldThreshold && currentTime < SilverThreshold)
		{
			Instantiate(SilverObj,new Vector3(0,0,0),Quaternion.identity);
	    }
		
		if (currentTime >= SilverThreshold)
		{
			Instantiate(BronzeObj,new Vector3(0,0,0),Quaternion.identity);
	    }
		}
		catch{};

		
		isUIshown = true;

	}

}

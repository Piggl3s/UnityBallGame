using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScript : MonoBehaviour {

public float CamUnlockPosition;

public int LevelResetNum=0;

public float SceneRestartPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var player =  GameObject.Find("RollerBall").GetComponent<Transform>().position;
		if (player.y < CamUnlockPosition)
		{
			GameObject.Find("Main Camera").GetComponent<CameraScript>().LockCamera = false;
		} 
  		bool isLevelComplete = GameObject.FindGameObjectWithTag("LevelCompleter").GetComponent<LevelCompleteScript>().isLevelComplete;
		if (player.y < SceneRestartPosition)
		{
			if(isLevelComplete) Destroy(gameObject);
			else SceneManager.LoadScene(LevelResetNum);
		}

	}
}

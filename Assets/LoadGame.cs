using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LoadGame : MonoBehaviour {

public int sceneToLoad = 0;
	// Use this for initialization
	
	// Update is called once per frame
	void Start() {
	
		GetComponent<Button>().onClick.AddListener(OnMouseDown);
	}

	void OnMouseDown(){	
           SceneManager.LoadScene(sceneToLoad);        
	}
}

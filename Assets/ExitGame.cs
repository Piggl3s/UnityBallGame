using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour {

	// Use this for initialization

	void Start() {
	
		GetComponent<Button>().onClick.AddListener(OnMouseDown);
	}

	void OnMouseDown(){	
          Application.Quit();      
	}
}

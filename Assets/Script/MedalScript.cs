using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
				var parent = GameObject.Find("CompleteCanvas").GetComponent<Transform>();
				transform.SetParent(parent);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

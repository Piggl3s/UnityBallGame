using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour {

public float worldGrav;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var gravDirection = new Vector3(0,worldGrav,0);
		  UnityEngine.Physics.gravity = gravDirection; 
	}
}

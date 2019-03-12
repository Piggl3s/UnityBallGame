using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

public float CameraHeight;

public float CameraDistance;

public bool LockCamera;

private Vector3 camPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	try{
	 var foo = GameObject.Find("RollerBall").transform.position;
	 if (LockCamera)
	 {
		 camPosition = new Vector3(foo.x,foo.y + CameraHeight, foo.z - CameraDistance);
	 }
	
	 transform.position = camPosition;
	}catch{}
	}
}

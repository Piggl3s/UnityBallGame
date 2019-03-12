using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour {


	//public bool DestoryOnZero;
	

	public float ShrinkSpeed;

	public bool OnCollision;
	public bool ShrinkX;
	
	public bool ShrinkY;

	public bool ShrinkZ;

	private bool ShrinkReady = false;

	private Vector3 originalSize;
	private float tick = 0;
	// Use this for initialization
	void Start () {
		if (!OnCollision)
		{
			ShrinkReady = true;
		}
		originalSize = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		//tick += Time.timeScale * (Time.deltaTime * 60);
		if (ShrinkReady)
		{
			if (ShrinkX) originalSize.x -= ShrinkSpeed;
			if (ShrinkY) originalSize.y -= ShrinkSpeed;
			if (ShrinkZ) originalSize.z -= ShrinkSpeed;			
		}

		transform.localScale = originalSize;


		if (transform.localScale.x < 0 ||
			transform.localScale.y < 0 ||
			transform.localScale.z < 0)
			{
				Destroy(gameObject);
			}
		

	}

	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player")
		{
		if (OnCollision)
			{
				ShrinkReady = true;
			}
		}
	}
}

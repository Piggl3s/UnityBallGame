using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ScaleUpScript : MonoBehaviour {
		
	public float StartScale = 0.0001f;
	public float EndScale = 6;

	public bool Exponentiate= false;
	public bool VertScale = true;

	public bool HoriScale = false;

	public bool DepthScale = false;
	public float SpawnSpeed = 0;

	public bool IsSine = false;

	[HideInInspector]
	public bool VertFinished = false;

	[HideInInspector]
	public bool HoriFinished = false;

	[HideInInspector]
	public bool DepthFinished = false;

	private bool isYSwitch = false;
	private bool isXSwitch = false;

	private bool isZSwitch = false;
	



	private float Y;

	private float X;

	private float Z;

	// Use this for initialization
	void Start () {
		if (VertScale)Y = StartScale;
		else Y = transform.localScale.y;
		
		if (HoriScale)X = StartScale;
		else X = transform.localScale.x;

		if (DepthScale)Z = StartScale;
		else Z = transform.localScale.z;

	}		
		
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3(X,Y,Z);
		if (VertScale)Vert();	
		
		
		if (HoriScale){
			Hori();
		}

		if (DepthScale)
		{
			Depth();
		}
	}

	private void Vert()
	{
			if (isYSwitch == false)
		{
			if(Y < EndScale)
				{
					if (Exponentiate)Y *= SpawnSpeed;
					else Y += SpawnSpeed;
					
				}
				else
				{
					isYSwitch = true;
					if(!IsSine) VertFinished = true;
				}
		}
		else
		{
			if (IsSine)
			{
				if(Y > StartScale)
					{
						if (Exponentiate)Y /= SpawnSpeed;
						else Y -= SpawnSpeed;
					
					}	
				else
				{
						isYSwitch = false;
				}		
			}
		}
	}

	private void Hori()
	{
		if (isXSwitch == false)
		{
			if(X < EndScale)
				{
					if (Exponentiate)X *= SpawnSpeed;
					else X += SpawnSpeed;
					
				}
				else
				{
					isXSwitch = true;
					if(!IsSine) HoriFinished = true;
				}
		}
		else
		{
			if (IsSine)
			{
				if(X > StartScale)
					{
						if (Exponentiate)X /= SpawnSpeed;
						else X -= SpawnSpeed;
					
					}	
				else
				{
						isXSwitch = false;
				}		
			}
		}		
	}

	private void Depth()
	{
		if (isZSwitch == false)
		{
			if(Z < EndScale)
				{
					if (Exponentiate)Z *= SpawnSpeed;
					else Z += SpawnSpeed;
					
				}
				else
				{
					isZSwitch = true;
					if(!IsSine) DepthFinished = true;
				}
		}
		else
		{
			if (IsSine)
			{
				if(Z > StartScale)
					{
						if (Exponentiate)Z /= SpawnSpeed;
						else Z -= SpawnSpeed;
					
					}	
				else
				{
						isZSwitch = false;
				}		
			}
		}		
	}
}


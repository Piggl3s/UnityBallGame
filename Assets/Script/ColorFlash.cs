using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFlash : MonoBehaviour {
	[Tooltip("Time it takes to change to next colour")]
	public int flashDelay = 3;

	public List<Color> ColourSelection;
	
	public bool FlashOnLoad = false;

	private Color baseColor;
	private int tick;
	
	[Tooltip("If true the colors will flash randomly, false will flash in color order")]
	public bool ChaoticFlashing = false;
	private int foo; 
	// Use this for initialization
	void Update () {
		if (FlashOnLoad)
		{
			if (ChaoticFlashing) Flash();
			else
			{
				 SolidFlash();
			}
		}
	}
	
	public void Flash() {		
		//var currentAlpha = 255;
		
		baseColor = ColourSelection[foo];

		GetComponent<Renderer>().material.color = baseColor;
		//GetComponent<SpriteRenderer>().color = baseColor;	


		tick++;
		if (tick >= flashDelay){
			foo = Random.Range(0,ColourSelection.Count);
			tick = 0;
		}
	}

		//Flash colors in order
		public void SolidFlash() {		
		
	
			
		GetComponent<Renderer>().material.color = baseColor;
		tick++;
		baseColor = ColourSelection[foo];
		if (tick > flashDelay){
			foo ++;
			tick = 0;
		}
		if (foo >= ColourSelection.Count) foo = 0;
	}
}

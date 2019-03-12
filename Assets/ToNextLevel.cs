using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{

  public int LevelToLoad = 0;
  void Start()
    {
       
    }

    void Update()
    {
        bool isLevelComplete = GameObject.FindGameObjectWithTag("LevelCompleter").GetComponent<LevelCompleteScript>().isLevelComplete;
		 if (Input.GetMouseButtonDown(0) && isLevelComplete){
           SceneManager.LoadScene(LevelToLoad);
         }
      
    }
	
}
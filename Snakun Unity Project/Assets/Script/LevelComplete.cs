using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour {

	void OnEable () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void NextLevel()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}
}

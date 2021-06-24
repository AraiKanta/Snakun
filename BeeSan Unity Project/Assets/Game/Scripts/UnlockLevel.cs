using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UnlockLevel : MonoBehaviour {

	public GameObject PreviousLevel;
	public GameObject LockImg;
	void OnEnable()
	{

		if(PlayerPrefs.GetInt(PreviousLevel.gameObject.name)>0)
		{
			LockImg.SetActive(false);
			GetComponent<Button>().interactable = true;
		}else{
			LockImg.SetActive(true);
			GetComponent<Button>().interactable = false;
		}
	}
	
	public void LevelLoad()
	{
			SceneManager.LoadScene(gameObject.name);
	}
	
	
}

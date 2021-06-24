using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class InGameUI : MonoBehaviour 
{		
	public GameObject HUD;
	public GameObject GameOverUI;
	public GameObject Shops;
	public GameObject LevelComplete;
	public GameObject Help;
	public Text[] EggText;
	void OnEnable()
	{		
		Gameevents.OnGameOver += OnGameOver;
		Gameevents.OnGameComplete += OnGameComplete;
		GameOverUI.SetActive (false);
		HUD.SetActive (true);
		Shops.SetActive (false);
		LevelComplete.SetActive(false);
		if (PlayerPrefs.GetInt ("Help") > 3) {
			Help.SetActive (true);
			PlayerPrefs.SetInt ("Help", PlayerPrefs.GetInt ("Hepl") + 1);
		}

	}
	void OnDisable()
	{
		Gameevents.OnGameOver -= OnGameOver;
		Gameevents.OnGameComplete -= OnGameComplete;
	
	}
	void LateUpdate () 
	{
		foreach(var t in EggText)
		{
			t.text =  PlayerPrefs.GetInt ("Diamond").ToString ();
		}
	}
	void OnGameOver(System.Object obj,System.EventArgs args)
	{		
		GameOverUI.SetActive (true);
		HUD.SetActive (false);
	}
	public void HomeButton()
	{
		SceneManager.LoadScene ("MainMenu");
	}
	public void RestartButton()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);	
		
	}
	public void ShopbuttonGO()
	{
		Shops.SetActive (true);
		GameOverUI.SetActive (false);
		HUD.SetActive (false);
		PlayerPrefs.SetInt("Over",1);
	}
	public void ShopbuttonLC()
	{
		Shops.SetActive (true);
		LevelComplete.SetActive (false);
		HUD.SetActive (false);
		PlayerPrefs.SetInt("Over",0);
	}
	public void Shopback()
	{

		Shops.SetActive (false);
		if(PlayerPrefs.GetInt("Over") > 0)
		{
		GameOverUI.SetActive (true);
		}else{
				LevelComplete.SetActive (true);
		}		
		HUD.SetActive (false);
	}
	

	void Update()
	{
		if (Input.GetMouseButtonDown (0))
		{
			Help.SetActive (false);
		}
		
	}
	void OnGameComplete(System.Object obj,System.EventArgs args)
	{
		LevelComplete.SetActive(true);
		HUD.SetActive(false);
		Shops.SetActive(false);
		GameOverUI.SetActive(false);
		PlayerPrefs.SetInt(SceneManager.GetActiveScene().name,1);
	}
	public void NextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}

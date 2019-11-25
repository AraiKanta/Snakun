using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour {
	public GameObject Menu;
	public GameObject Exit;
	public GameObject Shopmenu;
	public GameObject LevelSelectmenu;
	public Text TotalMoney;
	public Text TotalPt;
	void Awake()
	{
		Menu.SetActive(true);
		Exit.SetActive(false);
		Shopmenu.SetActive(false);
		LevelSelectmenu.SetActive(false);
	}
	public void PlayButton()
	{
		LevelSelectmenu.SetActive(true);
		Menu.SetActive(false);
	}
	public void LvSelectBack(){
		LevelSelectmenu.SetActive(false);
		Menu.SetActive(true);
	}
	public void ShopButton()
	{
		if (Shopmenu != null) {
			Shopmenu.SetActive (true);
		}
		if (Menu != null) {
			Menu.SetActive (false);
		}
		if (Exit != null) {
			Exit.SetActive (false);
		}
	}
	public void ExitButton(){
		if (Shopmenu != null) {
			Shopmenu.SetActive (false);
		}
		if (Menu != null) {
			Menu.SetActive (false);
		}
		if (Exit != null) {
			Exit.SetActive (true);
		}
	}
	public void ShopBackButton()
	{
		if (Shopmenu != null) {
			Shopmenu.SetActive (false);
		}
		if (Menu != null) {
			Menu.SetActive (true);
		}
		if (Exit != null) {
			Exit.SetActive (false);
		}
	}
	public void ExitYes(){
		Application.Quit ();
	}
	public void ExitNo(){
		Shopmenu.SetActive (false);
		Menu.SetActive (true);
		Exit.SetActive (false);
	}
	public void ShowLeaderboard()
	{
	}
	public void RateUs(){
		Application.OpenURL ("https://play.google.com/store/apps/details?id=" + Application.identifier);
	}

	void Update()
	{
		TotalPt.text = TotalMoney.text = PlayerPrefs.GetInt ("Diamond").ToString();	
		if(Input.GetKeyDown(KeyCode.A)){
			PlayerPrefs.DeleteAll();
		}
			if(Input.GetKeyDown(KeyCode.D)){
			PlayerPrefs.SetInt("Diamond",1000);
		}
	}
}

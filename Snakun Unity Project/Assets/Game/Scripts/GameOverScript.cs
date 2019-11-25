using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScript : MonoBehaviour {
		
	
	public Text Eggs;
	void OnEnable(){

	}
	// Update is called once per frame
	void Update () {
		Eggs.text = PlayerPrefs.GetInt("Diamond").ToString();
		}
		




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SnakeSelection : MonoBehaviour {

	public int snakePrise;
	public GameObject Tohide;
	public bool Purchaced;
	public Text PriseText;
	public int shopindex;
	void OnEnable()
	{
	
		if(snakePrise <=PlayerPrefs.GetInt("Diamond"))
		{
			GetComponent<Button>().enabled = true;
			Tohide.SetActive(false);
		}else{
		GetComponent<Button>().enabled = false;
			Tohide.SetActive(true);
		}
	
		
	}
	public void Selectbutton()
	{
		if(PlayerPrefs.GetInt(gameObject.name)> 0)
		{
				PlayerPrefs.SetInt("ShopItem",shopindex);
				Debug.Log(gameObject.name);
		}else
		if(snakePrise <= PlayerPrefs.GetInt("Diamond"))
		{
				
				Debug.Log(gameObject.name + "das");
				PlayerPrefs.SetInt(gameObject.name,1);
				Tohide.SetActive(false);
				PlayerPrefs.SetInt("ShopItem",shopindex);
				PlayerPrefs.SetInt("Diamond",PlayerPrefs.GetInt("Diamond") - snakePrise);
		}
	}
	void LateUpdate(){
		PriseText.text = snakePrise.ToString();
	}
}

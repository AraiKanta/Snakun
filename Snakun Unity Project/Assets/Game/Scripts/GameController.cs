using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
public GameObject Player;
	public GameObject[] PlayerPrefabs;
	public GameObject IngameUIprefab;
	public GameObject SoundPrefab;
	
//	public Material[] pattern;
	void Awake(){
	
		// GameObject[] objs= GameObject.FindGameObjectsWithTag("Obstacle");
		// 	foreach(GameObject o in objs){
		// 		o.GetComponent<MeshRenderer>().material = pattern[Random.Range(0,)]
		// 	}
		if(FindObjectOfType<InGameUI>() == null){
			
			Instantiate(IngameUIprefab);
		}else{
			Destroy(FindObjectOfType<InGameUI>().gameObject);
			Instantiate(IngameUIprefab);
		}
		if(FindObjectOfType<SoundController>() == null){
			
			Instantiate(SoundPrefab);
		}else{
			Destroy(FindObjectOfType<SoundController>().gameObject);
			Instantiate(SoundPrefab);
		}
	}
	// Use this for initialization
	void Start () 
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		if (Player == null) {
			Instantiate (PlayerPrefabs [PlayerPrefs.GetInt ("ShopItem")], Vector3.zero, Quaternion.identity);

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

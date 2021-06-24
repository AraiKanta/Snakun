using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[Header("Game Score Variables")]
	public static int currentScore;
	[Header("Obstacle Prefabs")]
	public List <GameObject> ObstaclesEasy = new List<GameObject>();
	public Transform SpawnPoint;
	public GameObject Player;
	public GameObject[] PlayerPrefabs;
	public static bool GameOver = false;
	public static bool GameStart = false;


	public float times;
	void Awake()
	{
		currentScore = 0;

	}
	void OnEnable(){
//		Gameevents.OnGameOver += OnGameOver;
	}
	void OnDisable(){
	//	Gameevents.OnGameOver -= OnGameOver;
	}
	// Use this for initialization
	void Start () 
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		if (Player == null) {
			Instantiate (PlayerPrefabs [PlayerPrefs.GetInt ("ShopItem1")], Vector3.zero, Quaternion.identity);

		}
		//InvokeRepeating("CreateObstacle",2,2);
	}

public	void CreateObstacle(Transform spawnpt)
	{
			
		Instantiate (ObstaclesEasy[Random.Range (0, ObstaclesEasy.Count)], spawnpt.position, Quaternion.identity);		
		
	
	}
	

public float InstantiationTimer = 50000f;
	void FixedUpdate()
	{
		times += Time.deltaTime;
		if (!GameOver && GameStart) {
		//	CreateObstacle ();
			float t = Time.deltaTime;		
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			PlayerPrefs.DeleteAll();
		}
	}



	

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerControl : MonoBehaviour 
{	

	public float Speed;
	public Vector3 direction;
	bool right = false;
	public GameObject gameendObject;
	public Transform Head;
	public TrailRenderer Treail;
	
	void Awake(){
		GameManager.GameStart = false;
		GameManager.GameOver = false;
	}
	void Start(){

	}
	void OnEnable(){

		ButtonScript.buttonDown += buttonDown;
	
	}
	void OnDisable(){
		ButtonScript.buttonDown -= buttonDown;

	}
	// Update is called once per frame
	void Update () 
	{
		
		if(!GameManager.GameOver)
		{		
			transform.position +=  direction * Time.deltaTime * Speed;		
				
			if (GameManager.GameStart) {
				//	Vector3 rot = Head.transform.eulerAngles;
				//	rot.z = Mathf.Clamp(rot.z,-45,45);
				//	Head.transform.eulerAngles = rot;
				if (right) {
					Head.transform.localEulerAngles =   new Vector3(0,0,direction.x * -45);
					//Head.transform.localEulerAngles =  Vector3.Lerp(Head.transform.localEulerAngles,new Vector3(0,0,-45),Time.deltaTime);//new Vector3(0,0,Mathf.Lerp(Head.transform.eulerAngles.z,-45,Time.deltaTime*8));				
					direction = Vector3.Lerp (direction, new Vector3 (1f, 1, 0), Time.deltaTime * 8);
				}
				if (!right) {
					
					Head.transform.localEulerAngles =   new Vector3(0,0,direction.x * -45); // Vector3.Lerp(Head.transform.localEulerAngles,new Vector3(0,0,45),Time.deltaTime); // new Vector3(0,0,Mathf.Lerp(Head.transform.eulerAngles.z,45,Time.deltaTime*8));
					direction = Vector3.Lerp (direction, new Vector3 (-1f, 1, 0), Time.deltaTime *8);
				}
			}
		}
		
	}
	void buttonDown(System.Object obj, System.EventArgs args)
    {
        switch (obj.ToString())
        {	
		case "Tap":
			GameManager.GameOver = false;
			right = !right;
			if (GameManager.GameStart == true) {
			} else {
				GameManager.GameStart = true;
			}

			
			break;
		}
	}
	void OnTriggerEnter(Collider incoming)
	{
		if(incoming.tag.Contains("Obstacle")){
			FindObjectOfType<SoundController> ().Cracs.Play ();
			direction = Vector3.zero;
			GameManager.GameOver = true;
				Instantiate (gameendObject, this.transform.position, Quaternion.identity);
			Treail.enabled = false;
			Head.gameObject.SetActive(false);
			Invoke ("OnGameOver",0.5f);
		}
		if (incoming.name.Contains ("Egg")) 
		{
				Instantiate (gameendObject, incoming.transform.position, Quaternion.identity);
			incoming.gameObject.SetActive(false);
			PlayerPrefs.SetInt ("Diamond", PlayerPrefs.GetInt ("Diamond") + 1);
			FindObjectOfType<SoundController> ().Collect.Play ();
		}
		if(incoming.name.Contains("Finish"))
		{
			
			Speed=0;
			Debug.Log("+++++++++++++++++++++++++++++++++");
			Gameevents.OnGameComplete(null,null);
		}
	}
	public void Restrat()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		GameManager.GameOver = false;
	}
	void OnGameOver()
	{
		Gameevents.OnGameOver (null,null);
	}
	
}

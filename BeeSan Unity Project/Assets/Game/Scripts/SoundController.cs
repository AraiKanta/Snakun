using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
	public AudioSource BGMusic;
	public AudioSource Cracs;
	public AudioSource Collect;
	// Use this for initialization
	void Start () {
		BGMusic.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

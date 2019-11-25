using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour {

	public Material thisMaterial;
	public Color[] randomcolor;
	int i =0;
	void Start () {
		
		i = Random.Range (0, randomcolor.Length);	
		thisMaterial.SetColor ("_Color",randomcolor[i]);
		thisMaterial.SetColor ("_TintColor",randomcolor[i]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

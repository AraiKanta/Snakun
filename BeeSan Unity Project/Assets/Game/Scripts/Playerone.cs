using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerone : MonoBehaviour {
	
	public Material materialColor;
	public Color  thiscolor;
	public Color[] colors;
	public SpriteRenderer spr;
	void OnEnable () {
		thiscolor = colors[Random.Range(0,colors.Length)];
		spr.color = thiscolor;
		materialColor.SetColor ("_Color", thiscolor);
	}

}

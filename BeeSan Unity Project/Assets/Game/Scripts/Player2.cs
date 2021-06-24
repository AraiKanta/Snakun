using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

	public Material thimat;
	public float Speed;
	
	// Update is called once per frame
	void Update () {
		thimat.SetTextureOffset ("_MainTex", new Vector2( Time.time / Speed,0));
	}
}

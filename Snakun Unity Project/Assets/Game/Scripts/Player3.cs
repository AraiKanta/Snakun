using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour {

	public Material thimat;

	
	// Update is called once per frame
	void Update () {
		thimat.SetTextureOffset ("_MainTex", new Vector2(0,Time.time));
	}
}

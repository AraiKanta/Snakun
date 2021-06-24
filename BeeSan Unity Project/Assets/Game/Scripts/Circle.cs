using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {
	float x;

	void Update () {
		 x = Mathf.Lerp (x,50,Time.deltaTime * 2);
	
		transform.localScale = new Vector3 (x,x,x);
	}
}

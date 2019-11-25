using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotateMove : MonoBehaviour {
	public Vector3 RotationSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(RotationSpeed.x * Time.deltaTime,RotationSpeed.y * Time.deltaTime,RotationSpeed.z * Time.deltaTime);
	}
}

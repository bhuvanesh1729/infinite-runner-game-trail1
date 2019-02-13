using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour {

	public GameObject target;
	public float smoothspeed=0.0125f; 
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (target != null) {
			Vector3 t = new Vector3 ();
			t.x = target.transform.position.x + offset.x;
			t.y = offset.y;
			t.z = target.transform.position.z + offset.z;
			transform.position = t;
		}
	}
}

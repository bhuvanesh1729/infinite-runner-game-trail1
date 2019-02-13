using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LooseGame : MonoBehaviour {

	public GameObject img;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collider)
	{
		Debug.Log("loose");
		if (collider.gameObject.tag == "Obsticle") {
			img.SetActive(true);
			Destroy (this.gameObject);
		}
	}

}

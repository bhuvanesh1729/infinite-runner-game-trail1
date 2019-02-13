using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Duplicate : MonoBehaviour {
	public Queue<GameObject> que;
	public GameObject[] arr;
	public GameObject[] prefab;
	public Vector3 offset;
	public GameObject[] pointsarr;
	public GameObject player;
	GameObject t;
	float maxCooldown;
	// Use this for initialization
	void Start () {
		que=new Queue<GameObject>();
		foreach (GameObject i in arr) {
			que.Enqueue (i);
		
		}
		 t = que.Dequeue (); 
	}

	// Update is called once per frame
	void Update () {
		if (player != null) {
			if (Vector3.Distance (t.transform.position, player.transform.position) > 35 && Vector3.Distance (t.transform.position, player.transform.position) < 65) {
				int i = Random.Range (0, 2);
				Vector3 newpos = t.transform.position + offset;
				GameObject l = Instantiate (prefab [i], newpos, Quaternion.identity);
				que.Enqueue (l);
				Destroy (t);
				t = que.Dequeue ();
			}
		}
	}

	public void LoadScen( string load)
	{
		SceneManager.LoadScene (load);	
	}

}

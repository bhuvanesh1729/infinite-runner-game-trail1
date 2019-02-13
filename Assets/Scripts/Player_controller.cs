using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_controller : MonoBehaviour {
	[SerializeField]
	private float max_speed;
	public int sinx;
	public Animator anim;
	public Text teext;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (Vector3.back*max_speed*Time.deltaTime);
		max_speed += Time.deltaTime /sinx;

		if (Input.GetMouseButtonDown (0)) {
			anim.SetTrigger ("Jump");
			score++;
			teext.text = score.ToString();
		} else if (Input.GetMouseButtonDown (1)) {
			anim.SetTrigger ("Duck");
			score++;
			teext.text = score.ToString();
		}
	}

}

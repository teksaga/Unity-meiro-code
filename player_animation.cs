using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_animation : MonoBehaviour {
	public GameObject player;
	public Animator anim;
	public bool flag;
	void Start () {
		player = GameObject.Find ("unitychan");
		anim = player.GetComponent<Animator> ();
		flag = false;
	}

	void Update () {
		_animation ();
	}
	void _animation(){
		if (Input.GetKeyDown (KeyCode.UpArrow) && !Input.GetKey(KeyCode.Space)  ||Input.GetKeyDown (KeyCode.DownArrow) && !Input.GetKey(KeyCode.Space)  || Input.GetKeyDown (KeyCode.RightArrow) && !Input.GetKey(KeyCode.Space)  ||Input.GetKeyDown (KeyCode.LeftArrow) && !Input.GetKey(KeyCode.Space)) {
			anim.SetTrigger ("walk_Trigger");
		}
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			flag = true;
		} else if (!Input.anyKey) {
			flag = false;
		}
		anim.SetBool ("walk", flag);
	}
}

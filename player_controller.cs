using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
	public GameObject player;
	void Start () {
		player = GameObject.Find ("unitychan");

	}

	void Update () {
		move ();
		rotate ();
	}
	void move(){
		if (Input.GetKey (KeyCode.UpArrow) && !Input.GetKey(KeyCode.Space) || Input.GetKey (KeyCode.DownArrow) && !Input.GetKey(KeyCode.Space) || Input.GetKey (KeyCode.RightArrow) && !Input.GetKey(KeyCode.Space) || Input.GetKey (KeyCode.LeftArrow) && !Input.GetKey(KeyCode.Space)) {
			player.transform.Translate (new Vector3 (0, 0, 0.1f));
		}
	}
	void rotate(){
		if (Input.GetKeyDown (KeyCode.RightArrow) && !Input.GetKey(KeyCode.Space)) {
			player.transform.Rotate (0, 45, 0);
		}else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space)) {
				player.transform.Rotate (0, 1, 0);
			}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && !Input.GetKey(KeyCode.Space)) {
			player.transform.Rotate (0, -45, 0);
		}else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space)) {
				player.transform.Rotate (0, -1, 0);
			}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			player.transform.Rotate (0,180, 0);
		}
	}
}

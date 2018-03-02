using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_control : MonoBehaviour {
	public GameObject Camera;
	public GameObject Player;
	void Start () {
		Player = GameObject.Find ("unitychan");
		Camera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		_rotate ();
		move ();
	}
	//Playerの回転にカメラが追従
	void _rotate(){
		Camera.transform.rotation = Quaternion.Euler (0, Player.transform.localEulerAngles.y, 0);
	}
	//Playerの動きにカメラが追従
	void  move(){
		//主観カメラの位置
		Camera.transform.position = new Vector3(Player.transform.position.x,Player.transform.position.y + 1.5f,Player.transform.position.z);
	}
}

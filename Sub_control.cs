using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sub_control : MonoBehaviour {

	public GameObject SubCamera;
	public GameObject Player;
	public Vector3 offset;
	void Start () {
		Player = GameObject.Find ("unitychan");
		SubCamera = GameObject.Find ("Sub_Camera");
		offset = Player.transform.position - SubCamera.transform.position;
	}

	// Update is called once per frame
	void Update () {
		move ();
		//_rotate ();
	}
	void  move(){
		//三人称視点カメラの位置
		SubCamera.transform.position = Player.transform.position - offset;
		}
	void _rotate(){
		SubCamera.transform.rotation = Quaternion.Euler (0,Player.transform.localEulerAngles.y,0);
	}
}

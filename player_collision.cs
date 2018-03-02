using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collision : MonoBehaviour {
	public GameObject Player;
	void Start () {
		Player = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//衝突時の呼び出し関数
	void OnCollisionEnter(Collision other){
		//ゴールだった場合
		if (other.transform.name == "Goul") {
			Debug.Log ("goul");
		}
	}
}

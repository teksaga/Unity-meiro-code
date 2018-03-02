using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour {
    public GameObject Camera;
    public GameObject SubCamera;
    void Start () {
		Camera = GameObject.Find ("Main Camera");
       	SubCamera = GameObject.Find ("Sub_Camera");
		Camera.SetActive (false);
		SubCamera.SetActive (true);
    }

    void Update () {
   		Camera_Change ();
    }
    //カメラの切り替え
    void Camera_Change(){
		if (Input.GetKeyDown (KeyCode.Space)) {
		    if (SubCamera.activeSelf) {
				Camera.SetActive (true);
				SubCamera.SetActive (false);
		    } else {
				Camera.SetActive (false);
				SubCamera.SetActive (true);
		    }
       	}
    }
}

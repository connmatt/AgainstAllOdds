using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    GameObject phone;
    Component pauseCam;
	// Use this for initialization
	void Start () {
        pauseCam = phone.GetComponent("Camera");
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("C"))
        {
           
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject smartphone;
    public GameObject phoneCamera;
    public GameObject phoneCanvas;
    public bool paused;
	// Use this for initialization
	void Start () {
        paused = false;
        smartphone = GameObject.FindGameObjectWithTag("phone");
        phoneCanvas= GameObject.FindGameObjectWithTag("phoneCanvas");
        phoneCamera = GameObject.FindGameObjectWithTag("phoneCamera");
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("escape"))
        {
            paused = !paused;
        }
        if(paused == true)
        {
            smartphone.SetActive(true);
            phoneCamera.SetActive(true);
            phoneCanvas.SetActive(true);
            Debug.Log(smartphone.activeSelf);
        }
        else if(paused == false)
        {
            smartphone.SetActive(false);
            phoneCamera.SetActive(false);
            phoneCanvas.SetActive(false);
            Debug.Log(smartphone.activeSelf);
        }
	}
}

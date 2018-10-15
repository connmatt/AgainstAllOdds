using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritTypeTwoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.color = new Color(gameObject.GetComponent<Renderer>().material.color.r, gameObject.GetComponent<Renderer>().material.color.g, gameObject.GetComponent<Renderer>().material.color.b, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

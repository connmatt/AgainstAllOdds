using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritTypeOneAI : MonoBehaviour {

    float angle;
	// Use this for initialization
	void Start () {
        angle = 0.0f;
        gameObject.GetComponent<Renderer>().material.color = new Color(gameObject.GetComponent<Renderer>().material.color.r, gameObject.GetComponent<Renderer>().material.color.g, gameObject.GetComponent<Renderer>().material.color.b, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
        angle += 0.05f;
        transform.position = new Vector3(transform.position.x, 
                                        transform.position.y + Mathf.Cos(angle) * 0.01f, 
                                        transform.position.z);
	}

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Player")
        {
            other.GetComponent<PlayerController>().changeSanity(25);
        }
    }
}

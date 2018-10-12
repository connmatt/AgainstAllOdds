using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritTypeOneAI : MonoBehaviour {

    float angle;
	// Use this for initialization
	void Start () {
        angle = 0.0f;
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
        else
        {
            Debug.Log("Spirit's broke");
        }
    }
}

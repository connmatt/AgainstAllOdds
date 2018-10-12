using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player") {
            other.gameObject.GetComponent<PlayerController>().changeHealth(-15);
        }
    }

}

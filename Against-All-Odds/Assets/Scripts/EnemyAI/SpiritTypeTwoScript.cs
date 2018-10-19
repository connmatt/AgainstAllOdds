using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritTypeTwoScript : MonoBehaviour {

    public float angle;
    public GameObject player;
    public bool hasSeen;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.color = new Color(gameObject.GetComponent<Renderer>().material.color.r, gameObject.GetComponent<Renderer>().material.color.g, gameObject.GetComponent<Renderer>().material.color.b, 0.5f);
        player = GameObject.Find("Player");
        hasSeen = false;
    }
	
	// Update is called once per frame
	void Update () {
        angle += 0.05f;
        transform.position = new Vector3(transform.position.x,
                                        transform.position.y + Mathf.Cos(angle) * 0.01f,
                                        transform.position.z);

        //RaycastHit hit;
        //if (Physics.Raycast(new Ray(transform.position,transform.forward), out hit,500.0f))
        //{
        //    if (hit.collider.tag == "Player")
        //    {
        //        player.GetComponent<PlayerController>().changeSanity(5);
        //    }
        //}

    }
}

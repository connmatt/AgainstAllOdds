using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritTypeOneAI : EnemyMoveScript {

    float angle;
	// Use this for initialization
	protected override void Start () {
        base.Start();
        angle = 0.0f;
        gameObject.GetComponent<Renderer>().material.color = new Color(gameObject.GetComponent<Renderer>().material.color.r, gameObject.GetComponent<Renderer>().material.color.g, gameObject.GetComponent<Renderer>().material.color.b, 0.5f);
        moveDistance(0, 0.5f, 0);
    }
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
        angle += 0.05f;
        moveDistance(0, Mathf.Cos(angle) * 0.01f, 0);
	}

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Player")
        {
            other.GetComponent<PlayerController>().changeSanity(25);
        }
    }
}

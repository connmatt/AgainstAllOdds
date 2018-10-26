using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritTypeTwoScript : EnemyMoveScript {

    public float angle;
    public GameObject player;
    public bool hasSeen;

	// Use this for initialization
	protected override void Start () {
        base.Start();
        gameObject.GetComponent<Renderer>().material.color = new Color(gameObject.GetComponent<Renderer>().material.color.r, gameObject.GetComponent<Renderer>().material.color.g, gameObject.GetComponent<Renderer>().material.color.b, 0.5f);
        moveDistance(0, 0.5f, 0);
        hasSeen = false;
    }
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
        angle += 0.05f;
        moveDistance(0, Mathf.Cos(angle) * 0.01f, 0);
        if (hasSeen)
        {
            Vanish();
        }

    }

    void Vanish()
    {
        base.startingPoint();
        hasSeen = false;
    }
}

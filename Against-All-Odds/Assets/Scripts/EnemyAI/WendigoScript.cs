using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoScript : EnemyMoveScript {

    public bool soundTriggered;
    public GameObject player;

	// Use this for initialization
	protected override void Start () {
        base.Start();
        soundTriggered = false;
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
        if (soundTriggered)
        {
            float step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(player.transform.position.x,
                            transform.position.y,
                            player.transform.position.z), step);
        }
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.transform.tag == "Player") {
            other.gameObject.GetComponent<PlayerController>().changeHealth(-15);
        }
    }

}

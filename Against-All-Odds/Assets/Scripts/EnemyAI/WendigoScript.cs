using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoScript : EnemyMoveScript {

	// Use this for initialization
	protected override void Start () {
        base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.transform.tag == "Player") {
            other.gameObject.GetComponent<PlayerController>().changeHealth(-15);
        }
    }

}

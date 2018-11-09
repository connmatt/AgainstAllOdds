using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoMeshMovement : MeshMovement {

    public bool soundTriggered;
    public bool stopping;

    // Use this for initialization
    protected override void Start () {
        base.Start();
        soundTriggered = false;
        stopping = false;
	}
	
	// Update is called once per frame
    /*
	void Update () {
        if (!stopping)
        {
            base.Update();
        }
        if ((!soundTriggered) && (player.GetComponent<PlayerController>().crouching == false) && (Vector3.Distance(transform.position, player.transform.position) <= 7f))
        {
            soundTriggered = true;
        }
    }
    */
}

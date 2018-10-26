using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoScript : EnemyMoveScript {

    public bool soundTriggered;
    private GameObject player;
    public bool stopping;

	// Use this for initialization
	protected override void Start () {
        base.Start();
        soundTriggered = false;
        stopping = false;
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	protected override void Update () {
        if (!stopping)
        {
            base.Update();
        }
        if ((!soundTriggered)&&(player.GetComponent<PlayerController>().crouching == false)&&(Vector3.Distance(transform.position,player.transform.position)<=7f))
        {
            soundTriggered = true;
            base.target = GameObject.FindWithTag("Player");
        }
        /*else if((soundTriggered)&&(player.GetComponent<PlayerController>().crouching == true) || (Vector3.Distance(transform.position, player.transform.position) > 7f))
        {
            soundTriggered = false;
            base.assignNewIndex();
        }*/
	}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.transform.tag == "Player") {
            other.gameObject.GetComponent<PlayerController>().changeHealth(-15);
            StartCoroutine(wendigoStop());
        }
    }

    IEnumerator wendigoStop()
    {
        stopping = true;
        yield return new WaitForSeconds(5f);
        stopping = false;
    }

}

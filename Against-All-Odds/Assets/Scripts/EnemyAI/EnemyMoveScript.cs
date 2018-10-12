using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour {

    public GameObject target;
    public float speed;

	// Use this for initialization
	void Start () {
        target = GameObject.Find("Player");
        Physics.IgnoreCollision(target.GetComponent<Collider>(), GetComponent<Collider>());
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(this.transform.position,
            new Vector3(target.transform.position.x, 
                        this.transform.position.y, 
                        target.transform.position.z), step);
	}
}

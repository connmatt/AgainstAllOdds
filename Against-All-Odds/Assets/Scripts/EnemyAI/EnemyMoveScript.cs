using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour {

    public GameObject target;
    public float speed;

	// Use this for initialization
	protected virtual void Start () {
        target = GameObject.Find("Player");
        Physics.IgnoreCollision(target.GetComponent<Collider>(), GetComponent<Collider>());
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(this.transform.position,
            new Vector3(target.transform.position.x, 
                        this.transform.position.y, 
                        target.transform.position.z), step);
	}

    // Moves the object over BY the specified distance
    public void moveDistance(float x, float y, float z)
    {
        transform.position = new Vector3(transform.position.x + x,
                                        transform.position.y + y,
                                        transform.position.z + z);
    }

    // Moves the object TO a specified location
    public void setLocation(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }
}

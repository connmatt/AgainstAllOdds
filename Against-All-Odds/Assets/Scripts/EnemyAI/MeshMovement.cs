using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshMovement : MonoBehaviour {

    public Transform target;
    // Use this for initialization
    protected virtual void Start () {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = target.position;
	}

}

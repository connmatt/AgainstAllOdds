using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{

    public GameObject target;
    public float speed;
    public GameObject[] waypoints;
    public int index;
    public int gotoIndex;
    public float heightIncrease;

    // Use this for initialization
    protected virtual void Start()
    {
        index = 0;
        gotoIndex = -1;
        startingPoint();
        assignNewIndex();
    }

    protected virtual void startingPoint()
    {
        do
        {
            index = Random.Range(0, waypoints.Length - 1);
        }
        while (waypoints[index].GetComponent<WaypointScript>().isVisited == true||gotoIndex==index);
        Debug.Log("test01");
        moveDistance(0, heightIncrease, 0);
        waypoints[index].GetComponent<WaypointScript>().isVisited = true;
        this.transform.position = waypoints[index].transform.position;
    }

    protected virtual void assignNewIndex()
    {
        do
        {
            gotoIndex = Random.Range(0, waypoints.Length-1);
        }
        while ((waypoints[gotoIndex].GetComponent<WaypointScript>().isVisited == true) || (gotoIndex == index));
        target = waypoints[gotoIndex];
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        float step = speed * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(transform.position,
            new Vector3(target.transform.position.x,
                        transform.position.y,
                        target.transform.position.z), step);
        if((this.transform.position!= waypoints[index].transform.position)&& (waypoints[index].GetComponent<WaypointScript>().isVisited == true)) {
            waypoints[index].GetComponent<WaypointScript>().isVisited = false;
        }
        if (Vector3.Distance(this.transform.position,waypoints[gotoIndex].transform.position)<=1f)
        {
            index = gotoIndex;
            waypoints[index].GetComponent<WaypointScript>().isVisited = true;
            assignNewIndex();
        }
    }

    // Moves the object over BY the specified distance
    public void moveDistance(float x, float y, float z)
    {
        this.transform.position = new Vector3(this.transform.position.x + x,
                                       this.transform.position.y + y,
                                        this.transform.position.z + z);
    }

    // Moves the object TO a specified location
    public void setLocation(float x, float y, float z)
    {
        this.transform.position = new Vector3(x, y, z);
    }
}

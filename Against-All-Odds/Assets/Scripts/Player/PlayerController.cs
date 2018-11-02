using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    /*
    public GameObject smartphone;
    public GameObject phoneCamera;
    public GameObject phoneCanvas;
    */
    public bool paused;
    public int sanity, health;
	// Use this for initialization
	void Start () {
        paused = false;
        sanity = 0;
        health = 100;
        //smartphone = GameObject.FindGameObjectWithTag("phone");
        //phoneCanvas= GameObject.FindGameObjectWithTag("phoneCanvas");
        //phoneCamera = GameObject.FindGameObjectWithTag("phoneCamera");
        GameObject.Find("Sanity").GetComponent<UnityEngine.UI.Text>().text = "Sanity: " + sanity;
        GameObject.Find("Health").GetComponent<UnityEngine.UI.Text>().text = "Health: " + health;
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("escape"))
        {
            paused = !paused;
        }
        if(paused == true)
        {
            //smartphone.SetActive(true);
            //phoneCamera.SetActive(true);
            //phoneCanvas.SetActive(true);
            //Debug.Log(smartphone.activeSelf);
        }
        else if(paused == false)
        {
            //smartphone.SetActive(false);
            //phoneCamera.SetActive(false);
            //phoneCanvas.SetActive(false);
            //Debug.Log(smartphone.activeSelf);
        }

        RaycastHit hit;
        if (Physics.SphereCast(new Ray(transform.position, transform.forward), 5.0f, out hit, 1.0f))
        {
            if (hit.collider.tag == "SpiritTypeTwo"&&!hit.collider.gameObject.GetComponent<SpiritTypeTwoScript>().hasSeen)
            {
                changeSanity(5);
                hit.collider.gameObject.GetComponent<SpiritTypeTwoScript>().hasSeen = true;
            }
        }
    }

    public void changeSanity(int s)
    {
        if (sanity < 100)
        {
            sanity += s;

            GameObject.Find("Sanity").GetComponent<UnityEngine.UI.Text>().text = "Sanity: " + sanity;
        }
    }

    public void changeHealth(int h)
    {
        if (health>0)
        {
            health += h;
            GameObject.Find("Health").GetComponent<UnityEngine.UI.Text>().text = "Health: " + health;
        }
    }
}

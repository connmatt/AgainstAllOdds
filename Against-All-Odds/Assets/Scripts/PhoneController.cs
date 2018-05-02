using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhoneController : MonoBehaviour {
    private PlayerController playerController;
    public Material cloudPhoneBackground;
    public Material backgroundNo2;
    int timer = 100;
    // Use this for initialization
    void Start () {
        Debug.Log(cloudPhoneBackground.color);
        Debug.Log(cloudPhoneBackground.shader);
        //Debug.Log(cloudPhoneBackground.SetTexture();
	}
	
	// Update is called once per frame
	void Update () {

        //timer--;
        //Debug.Log(timer);
        //phoneObject.material = backgroundNo2;
        //phoneObject.material = cloudPhoneBackground;
        //if(timer == 0)
        //{
        //    if(phoneObject.material == cloudPhoneBackground)
        //    {
        //        phoneObject.material = backgroundNo2;
        //    }
        //    else
        //    {
        //        phoneObject.material = cloudPhoneBackground;
        //    }
        //    timer = 100;
        //}
	}
}

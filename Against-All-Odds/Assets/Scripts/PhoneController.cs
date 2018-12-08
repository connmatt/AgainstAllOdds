using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhoneController : MonoBehaviour {
    private PlayerController playerController;
    public Texture[] m_Textures;

    Renderer m_Renderer;

    int timer = 100;
    // Use this for initialization
    void Start () {
        m_Renderer = GetComponent<Renderer>();

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetMouseButtonDown(1));
        Debug.Log(m_Renderer.material.mainTexture.Equals(m_Textures[0]));
        m_Renderer.material.SetTexture("smartphone_screen", m_Textures[0]);
        if (Input.GetMouseButtonDown(1))
        {
            if(m_Renderer.material.mainTexture.Equals("smartphone_screen"))
            {
                m_Renderer.material.SetTexture("smartphone_screen_2", m_Textures[0]);
            }
            else
            {
                m_Renderer.material.SetTexture("smartphone_screen", m_Textures[0]);
            }
        }
    }
}

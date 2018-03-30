using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour {
    [SerializeField]
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        SceneManager.LoadScene(sceneName);
    }
}

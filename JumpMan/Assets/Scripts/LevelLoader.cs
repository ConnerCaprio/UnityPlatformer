using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    private bool playerInExit;
    public string levelToLoad;

	// Use this for initialization
	void Start () {
        playerInExit = false;
	}
	
	// Update is called once per frame

	void Update () {
		if (playerInExit == true)
        {
            SceneManager.LoadScene(levelToLoad);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "PlayerIdle")
        {
            
            playerInExit = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour {

    public LevelManager manager;

    // Use this for initialization
    void Start () {
        manager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "PlayerIdle")
        {
            manager.NextLevel();
        }
    }
}

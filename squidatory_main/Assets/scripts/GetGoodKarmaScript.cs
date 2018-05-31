﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetGoodKarmaScript : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Play sound
        //FindObjectOfType<SoundManager>().Play("nameOfSound");

        //Add to good karma variable
        //GameManager.instance_.goodKarma_++;

        //Remove bad karma box
        Destroy(gameObject);

        //Return back to 3D world
        SceneManager.LoadScene("OuterWorld");

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

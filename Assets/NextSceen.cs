﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextSceen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKeyDown){
			SceneManager.LoadScene ("main");
		}
		
	}
}

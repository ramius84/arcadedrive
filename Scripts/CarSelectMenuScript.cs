﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarSelectMenuScript : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(5, 5, 100, 100), "Dashboard"))
        {
            SceneManager.LoadScene(1);
        }
    }

    // Use this for initialization
    void Start () {
        EnterCarScript.isPlayerInAnyCar = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

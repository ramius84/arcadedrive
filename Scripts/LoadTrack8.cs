﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTrack8 : MonoBehaviour {

	void OnGUI()
	{
        if (GUI.Button(new Rect(15, 100, 100, 50), "Track8"))
        {
            SceneManager.LoadScene(3);
        }
        if (GUI.Button(new Rect(15, 260, 100, 50), "Car Select"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void ConfirmButton()
    {
        SceneManager.LoadScene(3);
    }

    // Use this for initialization
    void Start () {
        EnterCarScript.isPlayerInAnyCar = false;
    }
	
	// Update is called once per frame
	void Update () {
		foreach(Touch touch in Input.touches)
		{
			if(gameObject.name == "Track8")
                SceneManager.LoadScene(3);
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;
  
    // Use this for initialization
    void Start ()
    {
      
        if (instance)
        {
          Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }
	
	// Update is called once per frame
	void Update () {

    }
}

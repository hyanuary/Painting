﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Transform>().localScale = new Vector2(paintGM.currentScale, paintGM.currentScale);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver()
    {
        if(paintGM.toolType == "eraser")
        {
            Destroy(gameObject);
        }
    }
}

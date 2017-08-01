using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        paintGM.currentColor = GetComponent<SpriteRenderer>().color;
        Debug.Log(paintGM.currentColor);
    }
}

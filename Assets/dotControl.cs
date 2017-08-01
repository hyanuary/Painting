using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dotControl : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        GetComponent<Transform>().localScale = new Vector2(paintGM.currentScale, paintGM.currentScale);
<<<<<<< HEAD
        GetComponent<SpriteRenderer>().color = paintGM.currentColor;
=======
        
>>>>>>> 7f90c6c42320d901c83450a8fd262f622ad330fc
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Delete))
        {
            Destroy(this.gameObject);
        }

	}

    private void OnMouseOver()
    {
        if(paintGM.toolType == "eraser")
        {
            Destroy(gameObject);
            
        }
    }
}

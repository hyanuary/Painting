using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintGM : MonoBehaviour {

    public Transform baseDot;
    public KeyCode mouseLeft;
    public static string toolType;
    public static float currentScale = 0.05f;

    public Texture2D text2d;

    Vector2 lastMousePos;

    //public bool onSomething;

	// Use this for initialization
	void Start () {

        lastMousePos = new Vector2(-1f, -1f);
        text2d = new Texture2D(512, 512);
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
       

        
            if (Input.GetKey(mouseLeft))
            {
            if (lastMousePos.x != -1f)
            {
                Vector2 offset = mousePosition - lastMousePos;
                float length = offset.magnitude;
                offset.Normalize();
                for (float i = 0; i < length; i += 5)
                {
                    Vector2 objPosition = Camera.main.ScreenToWorldPoint(lastMousePos + offset * i);
                    Instantiate(baseDot, objPosition, baseDot.rotation);

                }

            }
            else
            {
                Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                Instantiate(baseDot, objPosition, baseDot.rotation);
            }
                lastMousePos = mousePosition;
               
            }
            else
            {
                lastMousePos = new Vector2(-1f, -1f);
            }
        
        
	}

    void DrawPainting(Vector2 position)
    {
        
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    Vector3 puddlePos;
    // Use this for initialization
    void Start () {
      puddlePos = new Vector3(0.5f, this.transform.position.y, 0f);

    }
	
	// Update is called once per frame
	void Update () {
       
        float mouse_pause = (Input.mousePosition.x / Screen.width) * 16;
        puddlePos.x = Mathf.Clamp(mouse_pause, 0.396f, 15.606f);
        this.transform.position = puddlePos;
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreenScript : MonoBehaviour {

    public Canvas gameOverCanvas;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha0))
        {
            gameOverCanvas.GetComponent<Canvas>().enabled = true;
            this.GetComponent<Canvas>().enabled = false;
        }
	}
}

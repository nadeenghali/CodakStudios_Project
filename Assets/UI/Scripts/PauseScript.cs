using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public Canvas pauseCanvas;
    public static bool paused;

    // Use this for initialization
    void Start () {
        paused = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape) || Input.GetKeyUp(KeyCode.P))
        {
            Pause();
        }
    }

    public void Pause()
    {
        //and add anything that we change when we resume or pause
        Time.timeScale = 0;
        paused = true;

        pauseCanvas.GetComponent<Canvas>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }
}

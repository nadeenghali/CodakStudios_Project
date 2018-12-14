using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeScript : MonoBehaviour {

    public Canvas gameCanvas;

    public void Resume()
    {
        Time.timeScale = 1;
        PauseScript.paused = false;

        gameCanvas.GetComponent<Canvas>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }
}

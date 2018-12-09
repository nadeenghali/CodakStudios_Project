using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButtonScript : MonoBehaviour {

    public Canvas audioCanvas;

    public void SwitchCanvas()
    {
        audioCanvas.GetComponent<Canvas>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }
}

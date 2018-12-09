using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour {

    public Canvas optionsCanvas;

    public void SwitchCanvas()
    {
        optionsCanvas.GetComponent<Canvas>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButtonScript : MonoBehaviour {

    public Canvas upgradeCanvas;

    public void SwitchCanvas()
    {
        upgradeCanvas.GetComponent<Canvas>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }
}

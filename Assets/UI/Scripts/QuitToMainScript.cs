using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitToMainScript : MonoBehaviour {

    public void QuitToMain()
    {
        Time.timeScale = 1;
        PauseScript.paused = false;

        SceneManager.LoadScene("MainMenuScene");
    }
}

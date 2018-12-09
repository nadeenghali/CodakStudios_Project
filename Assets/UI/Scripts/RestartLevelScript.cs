using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelScript : MonoBehaviour {

    public void RestartLevel()
    {
        //and add anything that we change when we resume or pause
        Time.timeScale = 1;
        PauseScript.paused = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

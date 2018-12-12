using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelScript : MonoBehaviour {

    public void RestartLevel()
    {
        //Restart level should be same as next level in KratosLogic script

        //and add anything that we change when we resume or pause
        //unpause
        Time.timeScale = 1;
        PauseScript.paused = false;

        // Move player to starting point of this level (physically) -- shazly

        KratosLogic.healthPoints = 100;
        KratosLogic.XP = 0;
        KratosLogic.rage = 0;

        KratosLogic.canRageAttack = false;

        KratosLogic.lightAttack = false;
        KratosLogic.heavyAttack = false;
        KratosLogic.rageMode = false;

        KratosLogic.attackSkill = false;
        KratosLogic.movementSkill = false;
        KratosLogic.healthSkill = false;

        KratosLogic.gotHit = false;
        KratosLogic.gotKilled = false;
        KratosLogic.isBlocking = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

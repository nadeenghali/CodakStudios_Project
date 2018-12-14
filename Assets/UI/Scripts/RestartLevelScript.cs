using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartLevelScript : MonoBehaviour {

    public void RestartLevel()
    {
        Time.timeScale = 1;
        PauseScript.paused = false;

        // Move player to starting point of this level (physically) -- shazly

        KratosLogic.deadEnemies = 0;

        KratosLogic.healthPoints = 100;
        KratosLogic.XP = 0;
        KratosLogic.rage = 0;
        KratosLogic.skillPoints = 0;

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
        KratosLogic.isDead = false;
        KratosLogic.levelUp = false;
        KratosLogic.gameWon = false;
        
        if(KratosLogic.level == 1)
        {
            //level 1 position
        }

        if(KratosLogic.level == 2)
        {
            //level 2 position
        }

        if(KratosLogic.level == 3)
        {
            //level 3 position
        }
    }
}

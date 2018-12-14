using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KratosLogic : MonoBehaviour {

    public Canvas gameOverCanvas;
    public Canvas gameWonCanvas;
    public Canvas gameCanvas;

    public Text gameScreenSkills;
    public Text upgradeScreenSkills;

    public static int level;
    public static int deadEnemies;

    public static float healthPoints;
    public static float XP;
    public static float rage;
    public static float skillPoints;

    public static float maxHealthPoints;
    public static float maxXP;
    public static float maxRage;

    public static float minRage;

    public static bool canRageAttack;

    public static bool lightAttack;
    public static bool heavyAttack;
    public static bool rageMode;

    public static bool isBlocking;
    public static bool gotHit;
    public static bool gotKilled;
    public static bool isDead;

    public static bool movementSkill;
    public static bool attackSkill;
    public static bool healthSkill;

    public static bool levelUp;
    public static bool gameWon;

	// Use this for initialization
	void Start () {
        level = 1;
        deadEnemies = 0;

        healthPoints = 100;
        XP = 0;
        rage = 0;
        skillPoints = 0;

        maxHealthPoints = 100;
        maxXP = 500;
        maxRage = 100;

        minRage = 0;

        canRageAttack = false;

        lightAttack = false;
        heavyAttack = false;
        rageMode = false;

        attackSkill = false;
        movementSkill = false;
        healthSkill = false;

        gotHit = false;
        gotKilled = false;
        isBlocking = false;
        isDead = false;

        levelUp = false;
        gameWon = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (healthPoints <= 0 && isDead == false)
        {
            gotKilled = true;
            isDead = true;
            //wait 5 seconds to call GameOver();
            Invoke("GameOver", 5);    
        }

        if (XP >= maxXP)
        {
            LevelUp();
        }

        if (deadEnemies == 12)
        {
            NextLevel();
        }

        if (rage >= maxRage)
        {
            canRageAttack = true;
        }

        if(rage < maxRage)
        {
            canRageAttack = false;
        }

        if (movementSkill)
        {
            Kratos.walkSpeed = Kratos.walkSpeed * 1.1f;
            Kratos.runSpeed = Kratos.runSpeed * 1.1f;

            skillPoints = skillPoints - 1;
            movementSkill = false;
            levelUp = false;
        }

        if (healthSkill)
        {
            healthPoints = healthPoints * 1.1f;
            if (healthPoints > 100)
                healthPoints = 100;

            skillPoints = skillPoints - 1;
            healthSkill = false;
            levelUp = false;
        }

        if (gameWon)
        {
            GameWon();
            gameWon = false;
        }

        //gameScreenSkills.text = "Skill Points :  " + skillPoints;
        //upgradeScreenSkills.text = "Skill Points :  " + skillPoints;
    }

    public static void EnemyDead()
    {
        if (!rageMode)
        {
            rage = rage + 20;
            if (rage > maxRage)
            {
                rage = maxRage;
            }
        }

        deadEnemies = deadEnemies + 1;
    }

    public void GameOver()
    {
        print("Game over");
        gameOverCanvas.GetComponent<Canvas>().enabled = true;
        gameCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void GameWon()
    {
        print("Game Won");
        gameWonCanvas.GetComponent<Canvas>().enabled = true;
        gameCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void LevelUp()
    {
        skillPoints = skillPoints + 1;
        maxXP = maxXP * 2;
        levelUp = true;
    }

    public void NextLevel()
    {
        // Move player to next level (physically) -- shazly
        level = level++;
        deadEnemies = 0;

        canRageAttack = false;

        lightAttack = false;
        heavyAttack = false;
        rageMode = false;

        attackSkill = false;
        movementSkill = false;
        healthSkill = false;

        gotHit = false;
        gotKilled = false;
        isBlocking = false;
        isDead = false;

        levelUp = false;
    }
}

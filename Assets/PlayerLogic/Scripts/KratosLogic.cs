using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KratosLogic : MonoBehaviour {

   // public Canvas gameOverCanvas;

    public static int level;

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

    //Skills
    public static bool movementSkill;
    public static bool attackSkill;
    public static bool healthSkill;

	// Use this for initialization
	void Start () {
        level = 1;

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

    }
	
	// Update is called once per frame
	void Update () {
        if (healthPoints == 0)
        {
            gotKilled = true;
            //wait 5 seconds to call GameOver();
            Invoke("GameOver", 5);    
        }

        if(XP == maxXP)
        {
            NextLevel();
        }

        if(rage == maxRage)
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

            movementSkill = false;
        }

        if (healthSkill)
        {
            healthPoints = healthPoints * 1.1f;
            if (healthPoints > 100)
                healthPoints = 100;
            healthSkill = false;
        }
    }

    public void GameOver()
    {
        //gameOverCanvas.GetComponent<Canvas>().enabled = true;
        //this.GetComponent<Canvas>().enabled = false;
    }

    public void NextLevel()
    {
        // Move player to next level (physically) -- shazly

        level = level++;

        healthPoints = 100;
        XP = 0;
        rage = 0;

        // canvas text
        skillPoints = skillPoints + 1;

        maxXP = maxXP * 2;

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
    }

    /*public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HealthChest"))
        {
            //chest.open(); flag -- shazly
            healthPoints = 100;
        }
    }*/
}

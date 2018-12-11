using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KratosLogic : MonoBehaviour {

    public Canvas gameOverCanvas;

    public static int level;

    public static double healthPoints;
    public static double XP;
    public static double rage;
    public static double skillPoints;

    public static int maxHealthPoints;
    public static int maxXP;
    public static int maxRage;

    public static int minRage;

    public static bool heavyAttack;
    public static bool rageAttack;
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

        heavyAttack = false;
        rageAttack = false;

        attackSkill = false;
        movementSkill = false;
        healthSkill = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (healthPoints == 0)
        {
            GameOver();
        }

        if(XP == maxXP)
        {
            NextLevel();
        }

        if(rage == maxRage)
        {
            rageAttack = true;
        }

        if(rage == minRage)
        {
            rageAttack = false;
        }
        if (movementSkill)
        {
            //khali speeds public static in Kratos
            //Kratos.walkSpeed = Kratos.walkSpeed * 0.1f;
            //Kratos.runSpeed = Kratos.runSpeed * 0.1f;

            movementSkill = false;
        }

        if (healthSkill)
        {
            healthPoints *= 0.1f;
            healthSkill = false;
        }
    }

    public void GameOver()
    {
        gameOverCanvas.GetComponent<Canvas>().enabled = true;
        this.GetComponent<Canvas>().enabled = false;
    }

    public void NextLevel()
    {
        // Move player to next level (physically)

        level = level++;

        healthPoints = 100;
        XP = 0;
        rage = 0;

        //canvas text
        skillPoints += 1;

        maxXP = maxXP * 2;

        heavyAttack = false;
        rageAttack = false;

        attackSkill = false;
        movementSkill = false;
        healthSkill = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HealthChest"))
        {
            //chest.open(); flag
            healthPoints = 100;
        }
    }
}

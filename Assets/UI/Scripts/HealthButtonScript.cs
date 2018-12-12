using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthButtonScript : MonoBehaviour {

    public Text gameScreenSkills;
    public Text upgradeScreenSkills;

    public void UpgradeHealth()
    {
        if (KratosLogic.skillPoints > 0)
        {
            KratosLogic.healthSkill = true;
            KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
        }

        gameScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;
        upgradeScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;
    }
}

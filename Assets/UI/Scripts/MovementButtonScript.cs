using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementButtonScript : MonoBehaviour {

    public Text gameScreenSkills;
    public Text upgradeScreenSkills;

    public void UpgradeMovement()
    {
        if(KratosLogic.skillPoints > 0)
        {
            KratosLogic.movementSkill = true;
            KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
        }

        gameScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;
        upgradeScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;
    }
}

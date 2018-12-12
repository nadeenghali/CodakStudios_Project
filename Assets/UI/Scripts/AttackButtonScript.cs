using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButtonScript : MonoBehaviour {

    public Text gameScreenSkills;
    public Text upgradeScreenSkills;

    public void UpgradeAttack()
    {
        if (KratosLogic.skillPoints > 0)
        {
            KratosLogic.attackSkill = true;
            KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
        }

        gameScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;
        upgradeScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;
    }
}

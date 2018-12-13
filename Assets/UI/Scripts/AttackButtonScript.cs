using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButtonScript : MonoBehaviour {

    public void UpgradeAttack()
    {
        if (KratosLogic.skillPoints > 0 && KratosLogic.levelUp)
        {
            KratosLogic.attackSkill = true;
        }
    }
}

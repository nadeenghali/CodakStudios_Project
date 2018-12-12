using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButtonScript : MonoBehaviour {

    public void UpgradeAttack()
    {
        if (KratosLogic.skillPoints > 0)
        {
            KratosLogic.attackSkill = true;
            KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
        }
    }
}

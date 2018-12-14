using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthButtonScript : MonoBehaviour {

    public void UpgradeHealth()
    {
        if (KratosLogic.skillPoints > 0 && KratosLogic.levelUp)
        {
            KratosLogic.healthSkill = true;
        }
    }
}

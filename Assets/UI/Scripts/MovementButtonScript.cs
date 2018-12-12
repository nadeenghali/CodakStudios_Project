using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButtonScript : MonoBehaviour {

    public void UpgradeMovement()
    {
        if(KratosLogic.skillPoints > 0)
        {
            KratosLogic.movementSkill = true;
            KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
        }        
    }
}

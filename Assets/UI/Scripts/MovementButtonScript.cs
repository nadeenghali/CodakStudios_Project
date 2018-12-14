using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButtonScript : MonoBehaviour {

    public void UpgradeMovement()
    {
        if(KratosLogic.skillPoints > 0 && KratosLogic.levelUp)
        {
            KratosLogic.movementSkill = true;
        }        
    }
}

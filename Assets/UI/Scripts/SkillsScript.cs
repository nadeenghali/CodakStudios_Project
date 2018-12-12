using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsScript : MonoBehaviour {

    public Text gameScreenSkills;
    public Text upgradeScreenSkills;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;
        upgradeScreenSkills.text = "Skill Points :  " + KratosLogic.skillPoints;

        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            KratosLogic.skillPoints = KratosLogic.skillPoints + 1;
        }

        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
            if (KratosLogic.skillPoints < 0)
                KratosLogic.skillPoints = 0;
        }
    }
}

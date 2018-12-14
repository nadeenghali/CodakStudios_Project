using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            KratosLogic.skillPoints = KratosLogic.skillPoints + 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            if(KratosLogic.skillPoints >0)
                KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
        }
	}
}

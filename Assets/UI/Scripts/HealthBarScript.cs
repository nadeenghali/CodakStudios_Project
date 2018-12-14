using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    float xPos;
    float yPos;

    // Use this for initialization
    void Start () {
        xPos = this.GetComponent<RectTransform>().position.x;
        yPos = this.GetComponent<RectTransform>().position.y;
    }
	
	// Update is called once per frame
	void Update () {

        this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.healthPoints, this.GetComponent<RectTransform>().sizeDelta.y);
        this.GetComponent<RectTransform>().position = new Vector3( 60 + ((KratosLogic.healthPoints*50)/ KratosLogic.maxHealthPoints), yPos, 0);

        //CHEAT KEY 1 -> increase health 
        //CHEAT KEY 2 -> decrease health
        //increase health by 10
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            if(KratosLogic.healthPoints + 10 <= 100)
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.healthPoints + 10, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.healthPoints + 10) * 50) / KratosLogic.maxHealthPoints), yPos, 0);
            }
            else
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.maxHealthPoints, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.maxHealthPoints) * 50) / KratosLogic.maxHealthPoints), yPos, 0);
            }
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            if (KratosLogic.healthPoints - 10 >= 0)
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.healthPoints - 10, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.healthPoints - 10) * 50) / KratosLogic.maxHealthPoints), yPos, 0);
            }
            else
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(0, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3((60  / KratosLogic.maxHealthPoints), yPos, 0);
            }
        }
    }
}

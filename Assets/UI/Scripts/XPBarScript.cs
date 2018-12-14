using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBarScript : MonoBehaviour {

    float xPos;
    float yPos;

    // Use this for initialization
    void Start () {

        xPos = this.GetComponent<RectTransform>().position.x;
        yPos = this.GetComponent<RectTransform>().position.y;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2((KratosLogic.XP * 100)/KratosLogic.maxXP, this.GetComponent<RectTransform>().sizeDelta.y);
        this.GetComponent<RectTransform>().position = new Vector3(60 + ((KratosLogic.XP * 50)/ KratosLogic.maxXP), yPos, 0);


        //CHEAT KEY 3 -> increase XP by 50
        //CHEAT KEY 4 -> decrease XP by 50

        //increase XP
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            if(KratosLogic.XP + 50 <= KratosLogic.maxXP)
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(((KratosLogic.XP + 50) * 100) / KratosLogic.maxXP, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.XP + 50) * 50) / KratosLogic.maxXP), yPos, 0);
            }
            else
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(((KratosLogic.maxXP) * 100) / KratosLogic.maxXP, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.maxXP) * 50) / KratosLogic.maxXP), yPos, 0);
            }
        }

        //decrease XP
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            if (KratosLogic.XP + 50 >= 0)
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(((KratosLogic.XP - 50) * 100) / KratosLogic.maxXP, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.XP - 50) * 50) / KratosLogic.maxXP), yPos, 0);
            }
            else
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(0, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3((60 + KratosLogic.maxXP), yPos, 0);
            }
        }
    }
}

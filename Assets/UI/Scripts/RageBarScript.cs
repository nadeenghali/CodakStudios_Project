using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RageBarScript : MonoBehaviour {

    int counter;

    //CHEAT KEYS
    float xPos;
    float yPos;

    // Use this for initialization
    void Start () {
        counter = 0;

        //CHEAT KEYS
        xPos = this.GetComponent<RectTransform>().position.x;
        yPos = this.GetComponent<RectTransform>().position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (KratosLogic.rageMode)
        {
            if (KratosLogic.rage == 0)
            {
                KratosLogic.rageMode = false;
            }

            if (counter < 20)
            {
                Invoke("InRageModeDecrement", 1);
                counter++;
            } 
        }
        else
        {
            this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.rage, this.GetComponent<RectTransform>().sizeDelta.y);
            this.GetComponent<RectTransform>().position = new Vector3(60 + ((KratosLogic.rage * 50) / KratosLogic.maxRage), yPos, 0);
        }

        //CHEAT KEY 5 -> increase rage by 20
        //CHEAT KEY 6 -> decrease rage by 20

        //increase rage by 20
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            if(KratosLogic.rage + 20 <= 100)
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.rage + 20, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.rage +20) * 50) / KratosLogic.maxRage), yPos, 0);
            }
            else
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.maxRage , this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.maxRage) * 50) / KratosLogic.maxRage), yPos, 0);
            }
        }

        //decrease rage by 20 
        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            if (KratosLogic.rage - 20 >= 100)
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.rage - 20, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3(60 + (((KratosLogic.rage - 20) * 50) / KratosLogic.maxRage), yPos, 0);
            }
            else
            {
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(0, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().position = new Vector3((60  / KratosLogic.maxRage), yPos, 0);
            }
        }
    }

    public void InRageModeDecrement()
    {
        KratosLogic.rage = KratosLogic.rage - 5;

        this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.rage, this.GetComponent<RectTransform>().sizeDelta.y);
        this.GetComponent<RectTransform>().position = new Vector3(60 + ((KratosLogic.rage * 50) / KratosLogic.maxRage), yPos, 0);
    }
}

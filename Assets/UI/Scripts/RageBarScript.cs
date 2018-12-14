using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RageBarScript : MonoBehaviour {

    int counter;

    //CHEAT KEYS
    float xPos;
    float yPos;

    float w;

    float increase;
    float decrease;

    // Use this for initialization
    void Start () {
        counter = 0;

        //CHEAT KEYS
        xPos = this.GetComponent<RectTransform>().position.x;
        yPos = this.GetComponent<RectTransform>().position.y;

        w = this.GetComponent<RectTransform>().rect.width;

        increase = 5;
        decrease = 5;
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


        //CHEAT KEYS
        w = this.GetComponent<RectTransform>().rect.width;

        //increase health
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            if (w != 100)
            {
                w = w + increase;

                if (w > 100)
                {
                    w = 100;
                }

                xPos = (increase / 2);

                this.GetComponent<RectTransform>().sizeDelta = new Vector2(w, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().Translate(new Vector3(xPos, 0, 0));
            }
        }

        //decrease health
        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            if (w != 0)
            {
                w = w - decrease;

                if (w < 0)
                {
                    w = 0;
                }

                xPos = -(decrease / 2);

                this.GetComponent<RectTransform>().sizeDelta = new Vector2(w, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().Translate(new Vector3(xPos, 0, 0));
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

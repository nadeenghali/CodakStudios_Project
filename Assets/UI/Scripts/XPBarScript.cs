using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBarScript : MonoBehaviour {

    float difference;

    float myXP;
    float myMaxXP;

    float percentage;

    //CHEAT KEYS
    float xPos;
    float w;

    float increase;
    float decrease;

    // Use this for initialization
    void Start () {

        myXP = KratosLogic.XP;
        myMaxXP = KratosLogic.maxXP;

        difference = 0;

        percentage = 100 / myMaxXP;
        //CHEAT KEYS
        xPos = this.GetComponent<RectTransform>().position.x;
        w = this.GetComponent<RectTransform>().rect.width;

        increase = 10;
        decrease = 10;
    }

    // Update is called once per frame
    void Update()
    {

        difference = myXP - KratosLogic.XP;
        if (difference != 0)
        {
            difference = -(difference / 2);

            this.GetComponent<RectTransform>().sizeDelta = new Vector2((KratosLogic.XP * percentage), this.GetComponent<RectTransform>().sizeDelta.y);
            this.GetComponent<RectTransform>().Translate(new Vector3((difference * percentage), 0, 0));
        }

        myXP = KratosLogic.XP;
        myMaxXP = KratosLogic.maxXP;
        percentage = 100 / myMaxXP;

        //CHEAT KEYS
        w = this.GetComponent<RectTransform>().rect.width;

        //increase health
        if (Input.GetKeyUp(KeyCode.Alpha3))
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
        if (Input.GetKeyUp(KeyCode.Alpha4))
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
}

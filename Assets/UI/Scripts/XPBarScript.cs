using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBarScript : MonoBehaviour {

    //CHEAT KEYS
    float xPos;
    float yPos;

    float w;

    float increase;
    float decrease;

    // Use this for initialization
    void Start () {

        xPos = this.GetComponent<RectTransform>().position.x;
        yPos = this.GetComponent<RectTransform>().position.y;

        w = this.GetComponent<RectTransform>().rect.width;

        increase = 10;
        decrease = 10;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<RectTransform>().sizeDelta = new Vector2((KratosLogic.XP * 100)/KratosLogic.maxXP, this.GetComponent<RectTransform>().sizeDelta.y);
        this.GetComponent<RectTransform>().position = new Vector3(60 + ((KratosLogic.XP * 50)/ KratosLogic.maxXP), yPos, 0);


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
                this.GetComponent<RectTransform>().Translate(new Vector3(xPos, yPos, 0));
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
                this.GetComponent<RectTransform>().Translate(new Vector3(xPos, yPos, 0));
            }
        }
    }
}

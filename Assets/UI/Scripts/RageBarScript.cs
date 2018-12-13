using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RageBarScript : MonoBehaviour {

    float myRage;
    float myMinRage;

    float difference;
    int counter;

    //CHEAT KEYS
    float xPos;
    float w;

    float increase;
    float decrease;

    // Use this for initialization
    void Start () {

        myRage = KratosLogic.rage;
        myMinRage = KratosLogic.minRage;

        difference = 0;
        counter = 0;

        //CHEAT KEYS
        xPos = this.GetComponent<RectTransform>().position.x;
        w = this.GetComponent<RectTransform>().rect.width;

        increase = 5;
        decrease = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (KratosLogic.rageMode)
        {
            difference = 5;
            difference = -(difference/2);

            if (counter < 20)
            {
                Invoke("InRageModeDecrement", 1);
                counter++;
            }

            if(myRage == 0)
            {
                KratosLogic.rage = 0;
                KratosLogic.rageMode = false;
            }
        }
        else
        {
            difference = myRage - KratosLogic.rage;
            if (difference != 0)
            {
                difference = -(difference / 2);
                this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.rage, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().Translate(new Vector3(difference, 0, 0));
            }
            myRage = KratosLogic.rage;
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
        myRage = myRage - difference;
        KratosLogic.rage = myRage;

        this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.rage, this.GetComponent<RectTransform>().sizeDelta.y);
        this.GetComponent<RectTransform>().Translate(new Vector3(difference, 0, 0));
    }
}

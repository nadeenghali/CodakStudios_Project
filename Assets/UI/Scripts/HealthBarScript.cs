using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    float difference;

    float myHealthPoints;

    //CHEAT KEYS
    float xPos;
    float w;

    float increase;
    float decrease;

    // Use this for initialization
    void Start () {
        myHealthPoints = KratosLogic.healthPoints;

        difference = 0;

        //CHEAT KEYS
        xPos = this.GetComponent<RectTransform>().position.x;
        w = this.GetComponent<RectTransform>().rect.width;

        increase = 20;
        decrease = 20;
    }
	
	// Update is called once per frame
	void Update () {

        if(myHealthPoints - KratosLogic.healthPoints != 0)
        {
            difference = myHealthPoints - KratosLogic.healthPoints;

            if (difference > 0)
            {
                //decrease
                difference = (difference / 2);
            }
            else
            {
                //increase
                difference = -(difference / 2);
            }

            this.GetComponent<RectTransform>().sizeDelta = new Vector2(KratosLogic.healthPoints, this.GetComponent<RectTransform>().sizeDelta.y);
            this.GetComponent<RectTransform>().Translate(new Vector3(difference, 0, 0));
        }
        
        myHealthPoints = KratosLogic.healthPoints;



        // CHEAT KEYS
        w = this.GetComponent<RectTransform>().rect.width;
        //increase health
        if (Input.GetKeyUp(KeyCode.Alpha1))
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
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            if(w != 0)
            {
                w = w - decrease;

                if (w < 0)
                {
                    w = 0;
                }

                xPos = -(decrease / 2);

                this.GetComponent<RectTransform>().sizeDelta = new Vector2(w, this.GetComponent<RectTransform>().sizeDelta.y);
                this.GetComponent<RectTransform>().Translate(new Vector3(xPos, 0,0));
            }
        }
    }
}

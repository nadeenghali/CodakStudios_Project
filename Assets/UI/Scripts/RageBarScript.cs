using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RageBarScript : MonoBehaviour {

    float xPos;
    float w;

    float increase;
    float decrease;

    // Use this for initialization
    void Start () {
        xPos = this.GetComponent<RectTransform>().position.x;
        w = this.GetComponent<RectTransform>().rect.width;

        increase = 5;
        decrease = 5;
    }

    // Update is called once per frame
    void Update()
    {

        xPos = this.GetComponent<RectTransform>().position.x;
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
}

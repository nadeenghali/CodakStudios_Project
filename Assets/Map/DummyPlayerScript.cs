using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyPlayerScript : MonoBehaviour {

    float step = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Keyboard();
	}


    void Keyboard()
    {
        if (Input.GetKey(KeyCode.S))
        {
            step = 0.1f;
            transform.Translate(new Vector3(0.0f, 0.0f, step));
        }
        if (Input.GetKey(KeyCode.A))
        {
            step = 0.1f;
            transform.Translate(new Vector3(step, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            step = -0.1f;
            transform.Translate(new Vector3(0.0f, 0.0f, step));
        }
        if (Input.GetKey(KeyCode.D))
        {
            step = -0.1f;
            transform.Translate(new Vector3(step, 0.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.X))
        {
            step = -0.1f;
            transform.Translate(new Vector3(0.0f, step, 0.0f));
        }
        if (Input.GetKey(KeyCode.Z))
        {
            step = 0.1f;
            transform.Translate(new Vector3(0.0f, step, 0.0f));
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f, -5.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f, 5.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.R))
        {
            //transform.Rotate(5.0f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.T))
        {
            //transform.Rotate(-5.0f, 0.0f, 0.0f);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            print("HAHAHAHHAHA");
        }
    }
}

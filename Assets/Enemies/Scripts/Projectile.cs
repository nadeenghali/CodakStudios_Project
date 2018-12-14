using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    // Use this for initialization
    public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);

        //if (!KratosLogic.isBlocking)
                    
            // Enemy attacks kratos
            if (other.CompareTag("Kratos"))
            {
                print("Kratos hit collisoion");
                KratosLogic.healthPoints =
                    KratosLogic.healthPoints - 10;
                KratosLogic.gotHit = true;
                if (KratosLogic.healthPoints < 0)
                {
                    KratosLogic.healthPoints = 0;
                }
            }
        Destroy(this.gameObject);
    }
}


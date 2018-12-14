using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    // Use this for initialization
    float speed = 0.75f;
    GameObject Kratos;
    int x = 1;
    void Start() {
        Kratos = GameObject.FindGameObjectWithTag("Kratos");
        
    }

    // Update is called once per frame
    void Update() {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
      Vector3 omar = Kratos.transform.position - transform.position; //el vector ely angaz 7ayatna :') <3
      transform.Translate(omar * Time.deltaTime);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        

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


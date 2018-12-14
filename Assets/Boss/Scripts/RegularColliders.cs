using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularColliders : MonoBehaviour {

	// Use this for initialization
    string compareTag = "Target";
    private GameObject boss;
    private BossScript bossScript;
	void Start () {
        boss = GameObject.FindGameObjectWithTag("Boss");
        bossScript = boss.GetComponent<BossScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(compareTag))
        {
            bossScript.onHit("regular");
        }
    }
}

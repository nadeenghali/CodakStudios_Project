using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularColliders : MonoBehaviour {

	// Use this for initialization
    string compareTag = "Axe";
    private GameObject boss;
    private Kratos kratos_btates;

    private BossScript bossScript;
	void Start () {
        boss = GameObject.FindGameObjectWithTag("Boss");
        bossScript = boss.GetComponent<BossScript>();
        kratos_btates = GameObject.FindGameObjectWithTag("Target").GetComponent<Kratos>();
        gameObject.GetComponent<Collider>().isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(compareTag) && kratos_btates.isAttacking())
        {
            bossScript.onHit("regular");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakColliders : MonoBehaviour {

	// Use this for initialization
    // Use this for initialization
    string compareTag = "Axe";
    private GameObject boss;
    private Kratos kratos_btates;
    private BossScript bossScript;
    public string weakPoint;
    void Start()
    {
        boss = GameObject.FindGameObjectWithTag("Boss");
        kratos_btates = GameObject.FindGameObjectWithTag("Target").GetComponent<Kratos>();
        bossScript = boss.GetComponent<BossScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag(compareTag) && kratos_btates.isAttacking())
        {
            bossScript.onHit(weakPoint,KratosLogic.rageMode);
        }
        if (collision.CompareTag("Kratos") && boss.GetComponent<BossActions>().isAttacking()&&!KratosLogic.isBlocking)
        {
            KratosLogic.healthPoints =
                           KratosLogic.healthPoints - 10;
            KratosLogic.gotHit = true;
            if (KratosLogic.healthPoints < 0)
            {
                KratosLogic.healthPoints = 0;
            }
        }
    }
}

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
            bossScript.onHit(weakPoint);
        }
    }
}

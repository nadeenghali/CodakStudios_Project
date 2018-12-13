using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour {

	// Use this for initialization
	private NavMeshAgent agent;
	//public Transform goal;

    public static bool canAttack=false;

    public static float enemyHealthPoints;
    public float lightDamage;
    public float heavyDamage;

    public void Start () {
		agent= GetComponent<NavMeshAgent>();
		//SetTarget(goal.position);
        enemyHealthPoints = 50;
        lightDamage = 10;
        heavyDamage = 30;
    }

    // Update is called once per frame
    public void Update () {
        //if (transform.position.x > goal.position.x - 5 && transform.position.x < goal.position.x + 5)
          //  canAttack = true;
        //else
          //  canAttack = false;

        if(enemyHealthPoints <= 0)
        {
            //die anim then call DestroyEnemy()
            Invoke("DestroyEnemy", 5);
            DestroyEnemy();
        }
	}

    public void SetTarget(Vector3 pos)
    {
        agent.destination = pos;
    }

    public void OnTriggerEnter(Collider other)
    {
        float damage;
        int i = 1;

        if (!KratosLogic.isBlocking)
        {
            if (other.CompareTag("Axe"))
            {
                //print("axe hit collisoion");
                // Kratos attacks enemy
                if ((KratosLogic.lightAttack == true || KratosLogic.heavyAttack == true))
                {
                    if (KratosLogic.attackSkill)
                    {
                        heavyDamage = heavyDamage * 1.1f;
                        lightDamage = lightDamage * 1.1f;

                        KratosLogic.skillPoints = KratosLogic.skillPoints - 1;
                        KratosLogic.attackSkill = false;
                        KratosLogic.levelUp = false;
                    }

                    if (KratosLogic.rageMode)
                        i = 2;

                    if (KratosLogic.heavyAttack)
                        damage = heavyDamage * i;
                    else
                        damage = lightDamage * i;

                    enemyHealthPoints = enemyHealthPoints - damage;

                    if (!KratosLogic.rageMode)
                    {
                        KratosLogic.rage = KratosLogic.rage + 20;
                        if (KratosLogic.rage > KratosLogic.maxRage)
                        {
                            KratosLogic.rage = KratosLogic.maxRage;
                        }
                    }
                }
            }

            // Enemy attacks kratos
            if (other.CompareTag("Target"))
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
        } 
    }

    public void DestroyEnemy()
    {
        MapListener.KillEnemy();

        Destroy(this.gameObject);
        KratosLogic.XP = KratosLogic.XP + 50;
        if (KratosLogic.XP > KratosLogic.maxXP)
            KratosLogic.XP = KratosLogic.maxXP;
    }
}
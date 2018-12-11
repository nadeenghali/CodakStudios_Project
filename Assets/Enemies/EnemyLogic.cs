using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour {

	// Use this for initialization
	private NavMeshAgent agent;
	public Transform goal;

    public static bool canAttack=false;

    public static double enemyHealthPoints;

    public void Start () {
		agent= GetComponent<UnityEngine.AI.NavMeshAgent>();
		SetTarget(goal.position);
        enemyHealthPoints = 50;
    }

    // Update is called once per frame
    public void Update () {
        if (transform.position.x > goal.position.x - 5 && transform.position.x < goal.position.x + 5)
            canAttack = true;
        else
            canAttack = false;

        if(enemyHealthPoints == 0)
        {
            DestroyEnemy();
        }
	}

    public void SetTarget(Vector3 pos)
    {
        agent.destination = pos;
    }

    public void OnTriggerEnter(Collider other)
    {
        double damage;
        int i = 1;
        // Kratos attacks enemy
        if (other.CompareTag("Axe"))
        {
            if (KratosLogic.rageAttack)
                i = 2;

            if (KratosLogic.heavyAttack)
                damage = 30*i;
            else
                damage = 10*i;

            if (KratosLogic.attackSkill)
            {
                damage = damage * 0.1;
                KratosLogic.attackSkill = false;
            }
               
            enemyHealthPoints = enemyHealthPoints - damage;

            if (!KratosLogic.rageAttack)
                KratosLogic.rage = KratosLogic.rage + 20;
        }

        // Enemy attacks kratos
        if (other.CompareTag("Kratos"))
        {
            KratosLogic.healthPoints = KratosLogic.healthPoints - 10;
        }
    }

    public void DestroyEnemy()
    {
        Destroy(this.gameObject);
        KratosLogic.XP = KratosLogic.XP + 50;
    }
}
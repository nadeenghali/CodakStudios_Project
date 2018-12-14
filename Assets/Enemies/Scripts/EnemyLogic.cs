﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour {

	// Use this for initialization
	private NavMeshAgent agent;
    private Transform target;   
    //public Transform goal;

    public static bool canAttack=false;
    public static bool gotHit;
    public static float enemyHealthPoints;
    public float lightDamage;
    public float heavyDamage;

    public void Start () {
		agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Kratos").transform;
        SetTarget(target);
        enemyHealthPoints = 50;
        lightDamage = 10;
        heavyDamage = 30;
        gotHit = false;
    }

    // Update is called once per frame
    public void Update () {
        SetTarget(target);
        //if (transform.position.x > goal.position.x - 5 && transform.position.x < goal.position.x + 5)
        //   canAttack = true;
        //else
        //    canAttack = false;

        if (enemyHealthPoints <= 0)
        {
            //die anim then call DestroyEnemy()
            Invoke("DestroyEnemy", 5);
            //DestroyEnemy();
        }
	}

    public void SetTarget(Transform pos)
    {
        agent.destination = pos.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        float damage;
        int i = 1;

        //if (!KratosLogic.isBlocking)
        if(true)
        {
            if (other.CompareTag("Axe"))
            {
                //print("axe hit collisoion");
                // Kratos attacks enemy
                gotHit = true;
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

                    
                }
            }

            // Enemy attacks kratos
            if (other.CompareTag("Kratos"))
            {
                EnemyAnim.walking = true;
                print("Kratos hit collisoion");
                KratosLogic.healthPoints =
                    KratosLogic.healthPoints - 10;
                KratosLogic.gotHit = true;
                if (KratosLogic.healthPoints < 0)
                {
                    KratosLogic.healthPoints = 0;
                }
            }
            if (other.CompareTag("KratosPersonalSpace"))
            {
                EnemyAnim.walking = true;
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

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("KratosPersonalSpace"))
        {
            EnemyAnim.walking = false;
        }
    }
}
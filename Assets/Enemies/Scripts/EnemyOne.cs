﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyOne : MonoBehaviour {


    private NavMeshAgent agent;
    private Transform target;

    GameObject Kratos;

    Animator anim;
    float timeToAttack = 3f;

    bool walking = false;

    public static bool canAttack = false;
    public static bool gotHit;
    public static float enemyHealthPoints;
    public float lightDamage;
    public float heavyDamage;


    // Use this for initialization
    void Start () {
        Kratos = GameObject.FindGameObjectWithTag("Kratos");
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        target = Kratos.transform;
        SetTarget(target);
        enemyHealthPoints = 50;
        lightDamage = 10;
        heavyDamage = 30;
        gotHit = false;
    }
	
	// Update is called once per frame
	void Update () {
        SetTarget(target);
        CheckIfDead();
        Walk();
        Run();
        Dead();
        Attack();
        Hit();

    }
    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        float damage;
        int i = 1;

        //if (!KratosLogic.isBlocking)
        if (true)
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
                walking = true;
                //print("Kratos hit collisoion");
                KratosLogic.healthPoints =  KratosLogic.healthPoints - 10;
                KratosLogic.gotHit = true;
                if (KratosLogic.healthPoints < 0)
                {
                    KratosLogic.healthPoints = 0;
                }
            }
            if (other.CompareTag("KratosPersonalSpace"))
            {
             
               walking = true;
            }
        }
    }

    public void DestroyEnemy()
    {
        MapListener.KillEnemy();
        //KratosLogic.EnemyDead();

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
    public void SetTarget(Transform pos)
    {
        agent.destination = pos.position;
    }
    void CheckIfDead()
    {
        if (enemyHealthPoints <= 0)
        {

            Invoke("DestroyEnemy", 3);

        }
    }

    public void Attack()
    {
        Kratos.GetComponent<BoxCollider>().isTrigger = true;
        Invoke("ResetbBoxCollider", 1.5f);
        timeToAttack -= Time.deltaTime;
        if (timeToAttack <= 0 /*&& canAttack==true*/)
        {
            anim.SetBool("timeToAttack", true);
            anim.SetBool("Die", false);
            anim.SetBool("Hit", false);
            timeToAttack = 3.0f;
        }
    }

    public void Dead()
    {
        if (EnemyLogic.enemyHealthPoints <= 0)
        {
            anim.SetBool("timeToAttack", false);
            anim.SetBool("Die", true);
            anim.SetBool("Hit", false);
        }
    }

    void ResetbBoxCollider()
    {

        print("RESET !!!!!!!!!!!!!!!!!!");
        Kratos.GetComponent<BoxCollider>().isTrigger = false;
    }

    public void Run()
    {
        if (!walking)
        {
            if (timeToAttack > 0 && EnemyLogic.enemyHealthPoints > 0)
            {
                anim.SetBool("Running", true);
                anim.SetBool("timeToAttack", false);
                anim.SetBool("Die", false);
                anim.SetBool("Hit", false);
            }
        }
    }

    public void Hit()
    {
        if (EnemyLogic.gotHit)
        {
            anim.SetBool("timeToAttack", false);
            anim.SetBool("Die", false);
            anim.SetBool("Hit", true);
            EnemyLogic.gotHit = false;
        }
    }

    public void Walk()
    {
        if (walking)
        {
            anim.SetBool("Running", false);
        }
    }


}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour {

	// Use this for initialization
	Animator anim;
	float timeToAttack = 3f;
    //bool canAttack;
    //bool gotHit;
    public static bool walking = false;
	public void Start () {
	    anim = GetComponent<Animator>();
        //canAttack = EnemyLogic.canAttack;

    }

    // Update is called once per frame
    public void Update () {
        Walk();
        Run();
		Dead();
		Attack();
		Hit();
        
	}

    public void Attack() {
        timeToAttack -= Time.deltaTime;
        if (timeToAttack <= 0 /*&& canAttack==true*/)
        {
            
            anim.SetBool("timeToAttack", true);
            anim.SetBool("Die", false);
            anim.SetBool("Hit", false);
            timeToAttack = 3.0f;
        }
    }

    public void Dead(){
		if (EnemyLogic.enemyHealthPoints <= 0){
		anim.SetBool("timeToAttack", false);
		anim.SetBool("Die", true);
		anim.SetBool("Hit", false);
		}
	}

    public void Run() {
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

    public void Hit(){
       if (EnemyLogic.gotHit) {
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
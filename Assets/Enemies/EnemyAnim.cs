using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour {

	// Use this for initialization
	Animator anim;
	float timeToAttack = 30.0f;
	float health=50; 
    Enemy enemy;
    bool canAttack;
    bool gotHit;
	void Start () {
	 anim = GetComponent<Animator>();
     enemy = gameObject.GetComponent<Enemy>();
        canAttack = enemy.canAttack;
    }
	
	// Update is called once per frame
	void Update () {
		Run();
		Dead();
		Attack();
		Hit();
	}
    void Attack() {
        timeToAttack -= Time.deltaTime;
        if (timeToAttack <= 0 && canAttack==true)
        {
            anim.SetBool("timeToAttack", true);
            anim.SetBool("Die", false);
            anim.SetBool("Hit", false);
            timeToAttack = 30.0f;
        }
    }
	void Dead(){
		if (health <= 0){
		anim.SetBool("timeToAttack", false);
		anim.SetBool("Die", true);
		anim.SetBool("Hit", false);
		}
	}
    void Run() {
        if (timeToAttack > 0 && health > 0) {
            anim.SetBool("timeToAttack", false);
            anim.SetBool("Die", false);
            anim.SetBool("Hit", false);
        }
    }
        void Hit(){
            if (gotHit) {
                anim.SetBool("timeToAttack", false);
                anim.SetBool("Die", false);
                anim.SetBool("Hit", true);
            }
        }
}

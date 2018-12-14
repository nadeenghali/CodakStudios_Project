using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class BossScript : MonoBehaviour {

	// Use this for initialization
    private int HealthPoints = 200;
    public GameObject WeakPoint1, WeakPoint2, WeakPoint3;
    private int WeakPointOneHits, WeakPointTwoHits, WeakPointThreeHits;
    public ParticleSystem ps_wp_1, ps_wp_2_1, ps_wp_2_2, ps_wp_3;
    private BossActions bossActions;
    private NavMeshAgent agent;
    public GameObject[] enemy;
    public float waitTime = 5f;
    private float timer = 0f;
    private string target = "KratosPersonalSpace";
    public static bool inBossLevel = false ;

	void Start () {
        bossActions = gameObject.GetComponent<BossActions>();
        agent = gameObject.GetComponent<NavMeshAgent>();
        WeakPointOneHits = 2 ;
        WeakPointTwoHits = 2;
        WeakPointThreeHits = 2;
        agent.speed = 0f;
        Invoke("onActivateBoss", 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (agent.speed>0){
            bossActions.toggleParams(BossActions.Walking);
        }
     
        else
        {
            if (timer > waitTime)
            {

                Attack();
                timer = 0f;
            }
            else
            {
                bossActions.Idle();
            }
        }
	}
    void Attack()
    {
        ArrayList availableAttacks = GetAttacks();
        int randomIndex = Random.Range(0, availableAttacks.Count);
        bossActions.toggleParams((string)availableAttacks[randomIndex]);
    }
    void NormalHit()
    {
        HealthPoints = (int) (HealthPoints * 0.95);
        if (HealthPoints <= 0)
            Die();
    }
    void WeakHit()
    {
        HealthPoints = (int)(HealthPoints * 0.80);
        if (HealthPoints <= 0)
            Die();

    }
    public void onHit(string collision)
    {
        print(HealthPoints);
        if (!bossActions.isAttacking())
        {
            switch (collision)
            {
                case "Head": onHittingWeakPointTwo(); break;
                case "Axe": onHittingWeakPointOne(); break;
                case "Chest": onHittingWeakPointThree(); break;
                case "regular": NormalHit(); break;
            }
        }
      
    }
    void TurnOffMagicAttack1()
    {
        var em = ps_wp_1.emission;
        em.rateOverTime = 0.0f;
    }

    void TurnOffMagicAttack2()
    {
        var em = ps_wp_2_1.emission;
        em.rateOverTime = 0.0f;
        var em1 = ps_wp_2_2.emission;
        em1.rateOverTime = 0.0f;
    }
    void TurnOffMagicAttack3()
    {
        var em = ps_wp_3.emission;
        em.rateOverTime = 0.0f;
        
    }
    ArrayList GetAttacks()
    {
        ArrayList myAL = new ArrayList();
        myAL.Add(BossActions.Kick);
        myAL.Add(BossActions.MagicAttack1);
        if (WeakPointTwoHits > 0)
        {
            myAL.Add(BossActions.MagicAttack2);
        }
        if (WeakPointThreeHits > 0)
            myAL.Add(BossActions.MagicAttack3);
        return myAL;
    }

    void onHittingWeakPointOne()
    {
        WeakPointOneHits--;
        if (WeakPointOneHits == 0)
        {
            WeakHit();
            TurnOffMagicAttack1();
        }
    }

    void onHittingWeakPointTwo()
    {
        WeakPointTwoHits--;
        if (WeakPointTwoHits == 0)
        {
            WeakHit();
            TurnOffMagicAttack2();
        }
    }

    void onActivateBoss()
    {
        agent.speed = 2.0f;
        inBossLevel = true;
    }
    void onHittingWeakPointThree()
    {
        WeakPointThreeHits--;
        if (WeakPointThreeHits == 0)
        {
            WeakHit();
            TurnOffMagicAttack3();
        }
    }
    void Die()
    {
        bossActions.toggleParams("Die");
        bossActions.setDead();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(target))
        {
            agent.speed = 0.0f;
            timer = 4.5f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(target))
        {
            agent.speed = 2.0f;
        }
    }
   
}

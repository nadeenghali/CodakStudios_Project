using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	private UnityEngine.AI.NavMeshAgent agent;
	public Transform goal;
   public bool canAttack=false;
	void Start () {
		agent= GetComponent<UnityEngine.AI.NavMeshAgent>();
		setTarget(goal.position);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > goal.position.x - 5 && transform.position.x < goal.position.x + 5)
        {
            canAttack = true;
        }
        else
            canAttack = false;
	}
	void setTarget(Vector3 pos)
    {
    agent.destination = pos;
    }
}
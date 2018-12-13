using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class Patrol : MonoBehaviour
{
    Transform target;
    private NavMeshAgent agent;


    void Start()
    {
        target = GameObject.FindWithTag("Target").transform;
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        //GotoNextPoint();
    }


    void GotoNextPoint()
    {



       
 
    }


    void Update()
    {
        target = GameObject.FindWithTag("Target").transform;
        agent.destination = target.position;

        if (agent.pathPending)
        {
         
        }

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            //GotoNextPoint();
        }
    }
}
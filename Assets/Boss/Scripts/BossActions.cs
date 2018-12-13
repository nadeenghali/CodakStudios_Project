using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActions : MonoBehaviour {
public GameObject boss;
private AnimatorControllerParameter[] animParams;
private Animator animator; 
	// Use this for initialization
	void Start () {
        boss = gameObject; 
         animator = gameObject.GetComponent<Animator>();
        int animCount = animator.parameterCount;
        for(int i = 0 ; i < animCount ; i ++ ){
            animParams[i] = animator.GetParameter(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void doAction(string action)
    {
        for (int i = 0; i < animParams.Length; i++)
        {
            if (action.Equals(animParams[i].name))
            {
                animator.SetBool(animParams[i].name, true);
            }
            else
            {
                animator.SetBool(animParams[i].name, false);
            }
        }
        
    }
}

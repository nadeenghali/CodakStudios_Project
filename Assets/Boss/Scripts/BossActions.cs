using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActions : MonoBehaviour {
private AnimatorControllerParameter[] animParams;
private Animator animator;

public static string MagicAttack1 = "MagicAttack1";
public static string MagicAttack2 = "MagicAttack2";
public static string MagicAttack3 = "MagicAttack3";
public static string Dive = "Dive";
public static string Block = "Block";
public static string Kick = "Kick";
public static string Walking = "Walking";
public static string Die = "Die";
public static string ReactionToHead = "ReactionToHead";
public static string ReactionToGut = "ReactionToGut";





	// Use this for initialization
	void Start () {
        animator = gameObject.GetComponent<Animator>();
        int animCount = animator.parameterCount;
        animParams = new AnimatorControllerParameter[animCount]; 
        for(int i = 0 ; i < animCount ; i ++ ){
            animParams[i] = animator.GetParameter(i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public bool isAttacking()
    {

        return (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name.Contains("Dive")) ||
               (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name.Contains("Attack")) ||
               (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name.Contains("Power")) ||
               (animator.GetCurrentAnimatorClipInfo(0)[0].clip.name.Contains("Kick"));

    }
    public void toggleParams(string action)
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
    public bool isSecondAttackChoosen()
    {
        return animator.GetBool(MagicAttack2);
    }
    public void DoADive()
    {
        animator.SetBool(Dive, true);
    }
    public void Idle()
    {
        for (int i = 0; i < animParams.Length; i++)
        {
                animator.SetBool(animParams[i].name, false);
        }
    }
}

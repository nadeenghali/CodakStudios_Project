using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kratos : MonoBehaviour
{
    Animator anim;
    public static float runSpeed;
    public static float walkSpeed;
    GameObject Axe;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        runSpeed = 0.1f;
        walkSpeed = 0.07f;
        Axe = GameObject.FindGameObjectWithTag("Axe");
        Axe.GetComponent<BoxCollider>().isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {

        float translate_z = 0;
        float translate_x = 0;
 

        //Jump
        if (Input.GetKey(KeyCode.Space) && !KratosLogic.isDead)
        {
            if (anim.GetBool("Jump"))
            {
                anim.SetBool("Double_Jump", true);
                anim.SetBool("Jump", false);
                Invoke("resetDJump",2.5f);
               // this.GetComponent<Rigidbody>().AddForce(transform.up * 10, ForceMode.Impulse);
            }
            if (!anim.GetBool("Double_Jump") && !anim.GetBool("Jump"))
            {
                anim.SetBool("Jump", true);
                Invoke("resetDJump", 2.5f);
               // this.GetComponent<Rigidbody>().AddForce(transform.up * 10, ForceMode.Impulse);
            }
        }
        else
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Double_Jump", false);
        }

        //Waking to the sides
        if ((!(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) &&
            (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            && !KratosLogic.isDead)
        {

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(new Vector3(0, -3f, 0));
                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", true);
                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", false);

            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(new Vector3(0, 3f, 0));
                anim.SetBool("Right_Walking", true);
                anim.SetBool("Left_Walking", false);
                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", false);

            }
            else
            {

                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", false);


                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", false);
            }
        }


        if ((!(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) &&
            (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
            && !KratosLogic.isDead)
        {
            //AudioManager.startKratosWalking();
        }


        //Waking
        if ((!(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) &&
            (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            && !KratosLogic.isDead)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                translate_z = walkSpeed;
                anim.SetBool("Walk_Forward", true);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", false);


                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", false);

            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                translate_z = -walkSpeed;
                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", true);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", false);


                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", false);
            }
            else
            {
                //AudioManager.stopKratosWalking();
                translate_z = 0;
                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", false);


                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", false);
            }
        }

        //Running
        if ((Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) &&
            (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            && !KratosLogic.isDead)
        {

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                translate_z = runSpeed;
                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", true);
                anim.SetBool("Run_Back", false);


                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", false);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                translate_z = -runSpeed;
                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", true);


                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", false);
            }
            else
            {
                translate_z = 0;
                anim.SetBool("Walk_Forward", false);
                anim.SetBool("Walk_Back", false);

                anim.SetBool("Run_Forward", false);
                anim.SetBool("Run_Back", false);


                anim.SetBool("Right_Walking", false);
                anim.SetBool("Left_Walking", false);
            }
        }

        //die
        if (KratosLogic.gotKilled && KratosLogic.isDead)
        {
            anim.SetBool("Die", true);
            KratosLogic.gotKilled = false;
            //AudioManager.playKratosDies();
            print("Dead");
        }
        else if (!KratosLogic.gotKilled)
        {
            anim.SetBool("Die", false);
        }


        //got hit
        if (KratosLogic.gotHit && !KratosLogic.isDead) 
        {
            anim.SetBool("Hit_React", true);
            KratosLogic.gotHit = false;
            //AudioManager.playKratosIsHit();
        }
        else if (!KratosLogic.gotHit) 
            {
            anim.SetBool("Hit_React", false);
        }

        //Heavy Attack
        if (Input.GetMouseButton(1) && !KratosLogic.isDead)
        {
            anim.SetBool("Attack_360", true);
            KratosLogic.heavyAttack = true;
            Axe.GetComponent<BoxCollider>().isTrigger = true;
            Invoke("resetAxeTrigger", 2.4f);

        }
        else if (!Input.GetMouseButton(1))
        {
            anim.SetBool("Attack_360", false);
            KratosLogic.heavyAttack = false;
        }

        //Light Attack
        if (Input.GetMouseButton(0) && !KratosLogic.isDead)
        {
            anim.SetBool("Attack_Horizontal", true);
            KratosLogic.lightAttack = true;
            Axe.GetComponent<BoxCollider>().isTrigger = true;
            Invoke("resetAxeTrigger", 2.4f);
        }
        else if (!Input.GetMouseButton(0))
        {
            anim.SetBool("Attack_Horizontal", false);
            KratosLogic.lightAttack = false;
        }

        //Rage
        if (Input.GetKeyDown(KeyCode.R) && KratosLogic.canRageAttack && !KratosLogic.isDead)
        {
            anim.SetBool("Rage", true);
            KratosLogic.rageMode = true;
            //AudioManager.playKratosRage();
        }
        else if (!Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("Rage", false);
        }

        //Acrobatic Move
        if (Input.GetKeyDown(KeyCode.F) && !KratosLogic.isDead)
        {
            anim.SetBool("Flip", true);
        }
        else if (!Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("Flip", false);
        }

        //Block
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && !KratosLogic.isDead)
        {
            anim.SetBool("Block", true);
            KratosLogic.isBlocking = true;
        }
        else if (!(Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.RightControl)))
        {
            anim.SetBool("Block", false);
            KratosLogic.isBlocking = false;
        }

        //Not Walking nor Running
        if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow)
            && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) &&
            !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
        {
            translate_z = 0;
            anim.SetBool("Walk_Forward", false);
            anim.SetBool("Walk_Back", false);
            anim.SetBool("Run_Forward", false);
            anim.SetBool("Run_Back", false);
            anim.SetBool("Right_Walking", false);
            anim.SetBool("Left_Walking", false);
        }

        transform.Translate(translate_x, 0, translate_z);
    }

    public void resetAxeTrigger()
    {
        Axe.GetComponent<BoxCollider>().isTrigger = false;
    }
    public void resetDJump()
    {
        anim.SetBool("Double Jump", false);
    }

    public void resetJump()
    {
        anim.SetBool("Jump", false);
    }
    public bool isAttacking()
    {

        return (anim.GetCurrentAnimatorClipInfo(0)[0].clip.name.Contains("Attack"));

    }

}

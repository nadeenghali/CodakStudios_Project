using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kratos : MonoBehaviour
{
    Animator anim;
    public static float runSpeed;
    public static float walkSpeed;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        runSpeed = 0.1f;
        walkSpeed = 0.07f;
    }

    // Update is called once per frame
    void Update()
    {

        float translate_z = 0;
        float translate_x = 0;


        //Jump
        if (Input.GetKey(KeyCode.Space))
        {
            if (anim.GetBool("Jump"))
            {
                anim.SetBool("Double_Jump", true);
                anim.SetBool("Jump", false);
            }
            if (!anim.GetBool("Double_Jump") && !anim.GetBool("Jump"))
            {
                anim.SetBool("Jump", true);
            }
        }
        else
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Double_Jump", false);
        }

        //Waking to the sides
        if ((!(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) &&
            (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
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


        //Waking
        if ((!(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))) &&
            (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
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
            (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)))
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
        }
        else if (!KratosLogic.gotKilled)
        {
            anim.SetBool("Die", false);
        }


        //got hit
        if (KratosLogic.gotHit && !KratosLogic.gotKilled) 
        {
            anim.SetBool("Hit_React", true);
            KratosLogic.gotHit = false;
        }
        else if (!KratosLogic.gotHit) 
            {
            anim.SetBool("Hit_React", false);
        }

        //Heavy Attack
        if (Input.GetMouseButton(1))
        {
            anim.SetBool("Attack_360", true);
            KratosLogic.heavyAttack = true;
        }
        else if (!Input.GetMouseButton(1))
        {
            anim.SetBool("Attack_360", false);
            KratosLogic.heavyAttack = false;
        }

        //Light Attack
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("Attack_Horizontal", true);
            KratosLogic.lightAttack = true;
        }
        else if (!Input.GetMouseButton(0))
        {
            anim.SetBool("Attack_Horizontal", false);
            KratosLogic.lightAttack = false;
        }

        //Rage
        if (Input.GetKeyDown(KeyCode.R) && KratosLogic.canRageAttack)
        {
            anim.SetBool("Rage", true);
            KratosLogic.rageMode = true;
        }
        else if (!Input.GetKeyDown(KeyCode.R))
        {
            anim.SetBool("Rage", false);
        }

        //Acrobatic Move
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("Flip", true);
        }
        else if (!Input.GetKeyDown(KeyCode.F))
        {
            anim.SetBool("Flip", false);
        }

        //Block
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
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

}

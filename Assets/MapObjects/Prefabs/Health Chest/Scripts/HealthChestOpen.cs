using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthChestOpen : MonoBehaviour {

    public Animator animator;
    public static bool healthChestOpen;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Kratos")
        {
            healthChestOpen = true;
            animator.SetBool("healthChestOpen", healthChestOpen);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("IsWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("IsWalking", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        // Attacking logic
        if (Input.GetMouseButtonDown(0)) // Trigger attack when left mouse button is pressed
        {
            animator.SetBool("IsAttacking", true);
        }
        if (Input.GetMouseButtonUp(0)) // Stop attack when left mouse button is released
        {
            animator.SetBool("IsAttacking", false);
        }

    }
}

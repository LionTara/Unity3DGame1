using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GuardScript : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    private Animator animator;
    public bool seePlayer = false;
    public int damage = 20;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (seePlayer)
        {
            agent.SetDestination(player.transform.position);
            animator.SetBool("IsMoving", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Armature"))
        {
            seePlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("Armature"))
        {
            seePlayer= false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Armature"))
        {
            animator.SetTrigger("Attack1");
            animator.SetBool("IsMoving", true);

            PlayerHP playerHP = player.GetComponent<PlayerHP>();
            playerHP.damage(damage);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alien_walk_space_golem : MonoBehaviour
{
    public GameObject target;
    public float Radius = 13;
    public float dist;
    public int spped;
    private Animator myAnimator;
    private NavMeshAgent nav;
    private CharacterController controller;


    void Start()
    {
        myAnimator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        controller = GetComponent<CharacterController>();
        nav.speed = spped;
    }


    void Update()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > Radius)
        {
            nav.enabled = false;
            myAnimator.Play("Ide");
        }
        if (dist < Radius)
        {
            nav.enabled = true;
            nav.SetDestination(target.transform.position);
            if (dist <= nav.stoppingDistance)
            {
                nav.enabled = false;
                myAnimator.Play("Attack");
            }
            else
            {
                myAnimator.Play("Run");
            }
        }
    }
}

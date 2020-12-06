    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alien_walk : MonoBehaviour
{
    public GameObject target;
    public float Radius = 13;
    public float dist;
    public bool attack_can;
    public int spped;
    private Animator myAnimator;
    private NavMeshAgent nav;
    private CharacterController controller;


    void Start()
    {
        myAnimator = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist > Radius)
        {
            nav.enabled = false;
            attack_can = false;
            myAnimator.Play("Ide");
        }
        if (dist < Radius)
        {
            if (dist <= nav.stoppingDistance)
            {
                nav.speed = 0;
                nav.enabled = true;
                nav.SetDestination(target.transform.position);
                nav.enabled = false;
                attack_can = true;
                myAnimator.Play("Attack");
            }
            else
            {
                nav.speed = spped;
                nav.enabled = true;
                nav.SetDestination(target.transform.position);
                attack_can = false;
                myAnimator.Play("Run");
            }
        }
    }
}

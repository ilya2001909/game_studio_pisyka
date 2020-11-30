    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alien_walk : MonoBehaviour
{
    public GameObject player;
    public Animator enemy_anim;
    public float dist;
    NavMeshAgent nav;
    CharacterController controller;
    public float Radius = 13;
    public int spped;


    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        controller = GetComponent<CharacterController>();
        nav.speed = spped;
    }


    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > Radius)
        {
            nav.enabled = false;
            //gameObject.GetComponent<Animator>().SetTrigger("Idle");
        }
        if (dist < Radius)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            if (dist <= nav.stoppingDistance)
            {
                nav.enabled = false;
                enemy_anim.SetBool("can_attack", true);
            }
            else
            {
                nav.enabled = true;
                enemy_anim.SetBool("can_attack", false);
            }
            //gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
    }
}

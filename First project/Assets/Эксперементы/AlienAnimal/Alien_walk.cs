    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alien_walk : MonoBehaviour
{
    public GameObject player;
    public Animator player_anim;
    public float dist;
    NavMeshAgent nav;
    public float Radius = 13;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
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
            if (dist <= 6)
            {
                player_anim.SetBool("pisk", true);
            }
            else
            {
                player_anim.SetBool("pisk", false);
            }
            //gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
    }
}

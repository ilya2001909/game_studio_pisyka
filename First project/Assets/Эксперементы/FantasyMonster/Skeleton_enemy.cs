using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Skeleton_enemy : MonoBehaviour
{
    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float Radius = 13;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent> ();
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
            //gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
    }
}
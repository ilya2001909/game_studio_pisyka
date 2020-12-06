using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class life_enemy : MonoBehaviour
{
    public bool active_from_attack;
    public int hp_enemy;
    private Animator myAnimator;
    
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (hp_enemy <= 0)
        {
            die_enemy();
        }
    }

    public void die_enemy()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<CharacterController>().enabled = false;
        GetComponent<Alien_walk>().enabled = false;
        GetComponent<Take_damage_from_enemy>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        myAnimator.Play("Die");
        GetComponent<life_enemy>().enabled = false;
    }


}

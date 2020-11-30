using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_lapa : MonoBehaviour
{
    public Take_damage_from_enemy take_Damage_From_Enemy;
    public Animator animation;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            if (animation.GetBool("can_attack"))
            {
                take_Damage_From_Enemy.damege_from_lapa();
            }
        }
    }
}

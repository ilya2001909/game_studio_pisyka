using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_lapa : MonoBehaviour
{
    public Take_damage_from_enemy take_Damage_From_Enemy;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            take_Damage_From_Enemy.damege_from_lapa();
        }
    }
}

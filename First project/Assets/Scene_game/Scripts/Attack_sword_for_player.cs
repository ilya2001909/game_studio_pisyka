using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_sword_for_player : MonoBehaviour
{
    public Attack_player attack_Player;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            attack_Player.enemy = col.gameObject;
        }
    }

}

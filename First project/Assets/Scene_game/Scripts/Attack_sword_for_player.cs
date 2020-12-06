using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_sword_for_player : MonoBehaviour
{
    public Player_controller player_controller;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            player_controller.enemy_target = col.gameObject;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_damage_from_enemy : MonoBehaviour
{
    public DamageTaken DD;
    public GameObject player;
    public int damege_head;
    public int damege_lapa;

    public void damege_from_head()
    {
        if (GetComponent<Alien_walk>().attack_can)
        {
            DD.damage = damege_head;
        }
    }

    public void damege_from_lapa()
    {
        if (GetComponent<Alien_walk>().attack_can)
        {
            DD.damage = damege_lapa;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_damage_from_enemy : MonoBehaviour
{
    public DamageTaken DD;
    public int damege_head;
    public int damege_lapa;

    public void damege_from_head()
    {
        DD.damage = damege_head;
    }
    public void damege_from_lapa()
    {
        DD.damage = damege_lapa;
    }
}

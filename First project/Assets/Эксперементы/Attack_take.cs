using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_take : MonoBehaviour
{
    public DamageTaken DD;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            DD.damage = 10;
        }
    }
}

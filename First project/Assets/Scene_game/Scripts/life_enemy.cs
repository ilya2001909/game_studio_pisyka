using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life_enemy : MonoBehaviour
{
    public bool active_from_attack;
    public int hp_enemy;
    


    void Update()
    {
        if (hp_enemy <= 0)
        {
            die_enemy();
        }
    }

    public void die_enemy()
    {
        this.gameObject.SetActive(false);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_bar_script : MonoBehaviour
{
    Slider slider_hp_bar;
    public int hp_max;
    public float hp;
    public float hp_regen;
    private int cadr;

    // Start is called before the first frame update
    void Start()
    {
        slider_hp_bar = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider_hp_bar.value = hp/hp_max;
        cadr++;
        if (cadr == 7)
        {
            hp_buff();
            cadr = 0;
        }
    }

    void hp_buff()
    {
        if (hp > hp_max) { }
        else hp += hp_regen / 30;
    }

    public void GetDamage(int damage)
    {
        hp -= damage;
    }
}

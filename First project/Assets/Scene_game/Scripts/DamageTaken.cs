using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageTaken : MonoBehaviour
{
    public int damage;
    public Slider slider_hp;
    private HP_bar_script hP_Bar_Script;

    // Start is called before the first frame update
    void Start()
    {
        hP_Bar_Script = slider_hp.GetComponent<HP_bar_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (damage > 0)
        {
            hP_Bar_Script.GetDamage(damage);
            damage = 0;
        }
    }
}

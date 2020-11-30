using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_tyr : MonoBehaviour
{
    public Animation animation_attack;
    public AnimationClip male_attack;
    private GameObject player;
    public Avatar avatart;
    public bool attack;

    void Start()
    {
        player = this.gameObject;
        animation_attack = player.GetComponent<Animation>();
        animation_attack.AddClip(male_attack, "Male Attack 1");
    }

    // Update is called once per frame
    void Update()
    {
        if (attack)
        {
            animation_attack.PlayQueued(male_attack.name);
            animation_attack.Play(male_attack.name);
            attack = false;
        }
    }
}

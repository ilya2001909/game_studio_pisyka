using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_player : MonoBehaviour
{
    public PlayerMove movePlayer;
    public int damage;
    private float old_spped;
    private Animator animator;
    public GameObject enemy;
    public GameObject sword;

    // Start is called before the first frame update
    void Start()
    {
        old_spped = movePlayer.speed;
        animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {

    }

    public void click_ON_button_attack()
    {
        movePlayer.speed = 0;
        sword.SetActive(true);
        animator.SetBool("isRunning", false);
        animator.SetBool("isAttacking", true);
        Invoke("attack_end", 1f);
    }
    public void attack_end()
    {
        if (enemy != null)
        {
            enemy.GetComponent<life_enemy>().hp_enemy -= damage;
            movePlayer.speed = old_spped;
            animator.SetBool("isRunning", false);
            animator.SetBool("isAttacking", false);
            enemy = null;
            sword.SetActive(false);
        }
    }
}

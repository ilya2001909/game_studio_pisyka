using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_player : MonoBehaviour
{
    public PlayerMove movePlayer;
    private float old_spped;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        old_spped = movePlayer.speed;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            movePlayer.speed = 0;
            animator.SetBool("isRunning", false);
            animator.SetBool("isAttacking", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            movePlayer.speed = old_spped;
            animator.SetBool("isRunning", false);
            animator.SetBool("isAttacking", false);
        }

    }
}

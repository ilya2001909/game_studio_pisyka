using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public Joystick joystick;
    public float speed;
    public float speed_pov;
    private float turnSmoothVelocity;
    private Animator animator;
    public Event events;

    void Start()
    {
        speed_pov /= 100;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;
        Vector3 direction = new Vector3(x, 0f, z).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngel = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngel, ref turnSmoothVelocity, speed_pov);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(direction * speed * Time.deltaTime);
            animator.SetBool("isAttacking", false);
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

    }

    public void attack()
    {
        animator.SetBool("isAttacking", true);
    }
}

using UnityEngine;

public class Player_controller : MonoBehaviour
{
    private CharacterController controller;
    public GameObject enemy_target;
    public Joystick joystick;
    public float speed;
    public float speed_pov;
    private float turnSmoothVelocity;
    private Animator myAnimator;
    public Event events;
    public int damage;
    public bool ide = true;
    public bool walk;
    public bool attack;
    public float time;
    public float time_attack;

    void Start()
    {
        speed_pov /= 100;
        myAnimator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        if (attack)
        {
            time += Time.deltaTime;
        }

        if (time > time_attack)
        {
            time = 0;
            enemy_target = null;
            attack = false;
        }

        float x = joystick.Horizontal;
        float z = joystick.Vertical;
        x += Input.GetAxis("Horizontal");
        z += Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(x, 0f, z).normalized;

        if (direction.magnitude >= 0.1f && attack == false)
        {
            walk = true;
            ide = false;
        }
        else
        {
            if (attack == false)
            {
                walk = false;
                ide = true;
            }
        }

        if (walk)
        {
            float targetAngel = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngel, ref turnSmoothVelocity, speed_pov);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(direction * speed * Time.deltaTime);
            myAnimator.Play("Male_Sword_Walk");
        }

        if (ide)
        {
            myAnimator.Play("Male Sword Stance");
        }
    }

    public void _attack()
    {
        if (time == 0)
        {
            time = 0;
            walk = false;
            ide = false;
            attack = true;
            string name_animation = "Male Attack ";
            System.Random random = new System.Random();
            name_animation = name_animation + random.Next(1, 4).ToString();
            myAnimator.Play(name_animation);
            enemy_target.GetComponent<life_enemy>().hp_enemy -= damage;
        }
    }
    public void _rivok()
    {
        if (time == 0)
        {
            time = 0;
            walk = false;
            ide = false;
            attack = true;
            myAnimator.Play("Male Sword Roll");
        }
    }
}

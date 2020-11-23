using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public float speed_pov;
    private Vector3 velocity;

    void Start()
    {
        speed_pov /= 100;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2f;  
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
        
        
        float y_forward = transform.forward.y;

        Vector3 _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Vector3 direct = Vector3.RotateTowards(transform.forward, _moveDirection, speed_pov, 0.0f);
        transform.rotation = Quaternion.LookRotation(direct);

    }
}

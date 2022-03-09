/*
 * (Austin Buck)
 * (Assignment 5B)
 * (Controls player movement)
 */
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController cc;

    public Vector3 velocity;
    public float gravity = -9.81f;
    public float gravMultipliyer = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;

    public float jumpHeight = 3f;

    private void Awake()
    {
        gravity *= gravMultipliyer;
    }
    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * - 2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        cc.Move(velocity * Time.deltaTime);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        cc.Move(move * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool disabled = false;
    public CharacterController controller;
    float speed = 6f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public float jumpheight = 1f;

    public Transform groundcheck;
    public float grounddistance = 0.4f;
    public LayerMask groundmask;
    bool isgrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!disabled)
        {
            isgrounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundmask);

            if (isgrounded && velocity.y < 0)
            {   
                velocity.y = -2f;
            }
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && isgrounded)
            {
                velocity.y = Mathf.Sqrt(jumpheight * -2f * gravity);
            }
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}

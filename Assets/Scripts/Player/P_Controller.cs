using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Controller : MonoBehaviour
{
    private CharacterController cC;
    private Vector3 velocity;
    private bool isGrounded;
    void Start()
    {
        cC= GetComponent<CharacterController>();
    }

    void Update()
    {

        isGrounded = Physics.CheckSphere(GameManager.gM.pTransformGroundCheck.position, GameManager.gM.groundDistance, GameManager.gM.groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward* z;

        
        cC.Move(move * GameManager.gM.pSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(GameManager.gM.pjumpHeight * -2f * GameManager.gM.gravity);
        }

        velocity.y += GameManager.gM.gravity * Time.deltaTime;

        cC.Move(velocity * Time.deltaTime);
    }
}

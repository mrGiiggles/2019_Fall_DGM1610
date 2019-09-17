using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Movement : MonoBehaviour
{
    private Vector3 position;
    public CharacterController controller;
    
    public float speed = 1f;
    public float gravity = -3f;
    public float jumpSpeed = 100f;
    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");

        if (!controller.isGrounded)
        {
            position.y -= gravity;
        }
        else
        {
            position.y = 0f;
        }


        if (Input.GetButtonDown("Jump"))
        {
            position.y = jumpSpeed;
        }

        controller.Move(position*Time.deltaTime);
    }
}

using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public float sprintMultiplier;
    public float crouchMultiplier;
    public float gravity;

    private CharacterController control;
    private float verticalInput;
    private float horizontalInput;
    private float originalSpeed;
    private Vector3 moveDirection;

    void Start ()
    {
        control = GetComponent<CharacterController>();
        originalSpeed = speed;
    }
	
	void Update () {

        speed = originalSpeed;

        if (control.isGrounded)
        {
            if (Input.GetButton("Sprint"))
            {
                speed *= sprintMultiplier;
            }
            else if (Input.GetButton("Crouch"))
            {
                speed *= crouchMultiplier;
            }
            moveDirection = Vector3.zero;
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpForce;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        control.Move(moveDirection * Time.deltaTime);
    }
}

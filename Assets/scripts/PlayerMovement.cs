using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public Camera playerCamera;

    //Drag the OUTER PLAYER object here.
    public Transform playerParent;

    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public float defaultHeight = 2f;
    public float crouchHeight = 1f;
    public float crouchSpeed = 3f;

    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0f;
    private CharacterController characterController;

    private bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //Movement will now depend on where the WHOLE player is facing.
        Vector3 forward = playerParent.forward;
        Vector3 right = playerParent.right;

        bool isRunning = Input.GetKey(KeyCode.LeftShift);

        float curSpeedX =
            canMove ? (isRunning ? runSpeed : walkSpeed)
            * Input.GetAxis("Vertical") : 0;

        float curSpeedY =
            canMove ? (isRunning ? runSpeed : walkSpeed)
            * Input.GetAxis("Horizontal") : 0;

        float movementDirectionY = moveDirection.y;

        moveDirection =
            (forward * curSpeedX)
            + (right * curSpeedY);

        if (Input.GetButton("Jump")
            && canMove
            && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        //Crouching
        if (Input.GetKey(KeyCode.R) && canMove)
        {
            characterController.height = crouchHeight;
            walkSpeed = crouchSpeed;
            runSpeed = crouchSpeed;
        }
        else
        {
            characterController.height = defaultHeight;
            walkSpeed = 6f;
            runSpeed = 12f;
        }

        //Move the Character Controller.
        characterController.Move(moveDirection * Time.deltaTime);


        if (canMove)
        {
            //LOOK UP AND DOWN
            rotationX +=
                -Input.GetAxis("Mouse Y") * lookSpeed;

            rotationX =
                Mathf.Clamp(rotationX,
                -lookXLimit,
                lookXLimit);

            playerCamera.transform.localRotation =
                Quaternion.Euler(rotationX, 0, 0);


            //LOOK LEFT AND RIGHT
            playerParent.rotation *=
                Quaternion.Euler(
                    0,
                    Input.GetAxis("Mouse X") * lookSpeed,
                    0
                );
        }


        //Footstep sounds
        if (Input.GetAxisRaw("Horizontal") != 0 ||
            Input.GetAxisRaw("Vertical") != 0)
        {
            SoundManager.instance.StartWalk();
        }
        else
        {
            SoundManager.instance.StopWalk();
        }
    }


    public void ResetMovement()
    {
        moveDirection = Vector3.zero;
        rotationX = 0f;
    }


    public void SetCanMove(bool value)
    {
        canMove = value;
        Debug.Log("CanMove = " + value);
    }
}
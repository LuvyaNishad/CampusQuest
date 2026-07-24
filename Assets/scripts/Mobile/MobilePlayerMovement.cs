using UnityEngine;
using StarterAssets;

[RequireComponent(typeof(CharacterController))]
public class MobilePlayerMovement : MonoBehaviour
{
    [Header("References")]
    public Camera playerCamera;
    public StarterAssetsInputs input; // drag StarterAssetsInputs here

    [Header("Movement")]
    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;
    public float defaultHeight = 2f;
    public float crouchHeight = 1f;
    public float crouchSpeed = 3f;

    [Header("Look")]
    public float lookSensitivity = 0.8f;
    public float lookXLimit = 45f;

    private CharacterController cc;
    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0f;
    private bool canMove = true;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (!canMove) return;

        // --- Movement (from UIVirtualJoystick via StarterAssetsInputs) ---
        float speed = input.sprint ? runSpeed : walkSpeed;
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right   = transform.TransformDirection(Vector3.right);

        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * input.move.y * speed)
                      + (right  * input.move.x * speed);

        // --- Jump ---
        if (input.jump && cc.isGrounded)
        {
            moveDirection.y = jumpPower;
            input.jump = false;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        // --- Gravity ---
        if (!cc.isGrounded)
            moveDirection.y -= gravity * Time.deltaTime;

        cc.Move(moveDirection * Time.deltaTime);

        // --- Look (from UIVirtualTouchZone via StarterAssetsInputs) ---
        rotationX -= input.look.y * lookSensitivity;
        rotationX  = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.Rotate(0, input.look.x * lookSensitivity, 0);

        // reset look each frame (touch zone sends delta not state)
        input.LookInput(Vector2.zero);
    }

    public void SetCanMove(bool value) { canMove = value; }

    public void ResetMovement()
    {
        moveDirection = Vector3.zero;
        rotationX = 0f;
    }
}
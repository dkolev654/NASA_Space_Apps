using UnityEngine;

public class SwimmingController : MonoBehaviour
{
    public float swimSpeed = 5f;
    public float verticalSwimSpeed = 3f;
    public float drag = 0.1f;

    private CharacterController controller;
    private Vector3 movement;

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Ensuring CharacterController is attached
    }

    void Update()
    {
        // Horizontal movement input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Vertical (up/down) swimming input
        float swimUp = 0;
        if (Input.GetKey(KeyCode.Space))
        {
            swimUp = verticalSwimSpeed; // Ascend
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            swimUp = -verticalSwimSpeed; // Descend
        }

        // Create movement vector (Forward/back + up/down + strafe)
        Vector3 direction = transform.forward * vertical + transform.right * horizontal + transform.up * swimUp;
        movement = direction * swimSpeed;

        // Apply drag (for smooth swimming)
        movement *= (1 - drag);

        // Move the character using CharacterController
        controller.Move(movement * Time.deltaTime);
    }
}

using System.Collections;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float mouseSensitivity = 10000f;  // Sensitivity of the mouse movement
    public Transform playerBody;           // Reference to the player's body for horizontal rotation

    private float xRotation = 0f;          // Store vertical rotation value

    void Start()
    {
        // Lock the cursor to the center of the screen aßnd hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse input values
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Adjust vertical rotation (up/down), clamping to avoid full rotations
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // Prevent the camera from over-rotating

        // Apply the vertical rotation to the camera (this object)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotate the player's body left/right based on mouseX (horizontal movement)
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

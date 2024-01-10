using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of the camera movement
    public float rotateSpeed = 100.0f; // Speed of the camera rotation

    private float pitch = 0f; // Vertical rotation
    private float yaw = 0f; // Horizontal rotation

    void Update()
    {
        // Camera movement
        float horizontalMovement = Input.GetAxis("Horizontal"); // A and D keys
        float verticalMovement = Input.GetAxis("Vertical"); // W and S keys

        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        // Camera rotation
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            yaw -= rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            yaw += rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pitch -= rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pitch += rotateSpeed * Time.deltaTime;
        }

        // Apply rotation
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}

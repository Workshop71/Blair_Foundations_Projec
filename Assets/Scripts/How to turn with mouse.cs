using UnityEngine;

public class Howtoturnwithmouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform playerObj;
    public float mouseSensitivity = 2f;
    float cameraverticalRotation = 0f;

        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            Cursor.lockState = CursorLockMode.Locked;

            float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
            float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            cameraverticalRotation -= inputY;
            cameraverticalRotation = Mathf.Clamp(cameraverticalRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(cameraverticalRotation, 0f, 0f);

            playerObj.Rotate(Vector3.up * inputX);          
        }
}

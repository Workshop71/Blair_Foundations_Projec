using UnityEngine;

public class THErIGHTfUCKINGmOVEMENT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float rotationSpeed; // Speed of rotation
    Vector3 _movement;

    Rigidbody _rb;  
    public float movementSpeed = 5f; // Speed of movement
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward); 
        Vector3 right = transform.TransformDirection(Vector3.right); 
        _movement = forward * Input.GetAxis("Vertical") + right * Input.GetAxis("Horizontal");
    
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + new Vector3(_movement.x, 0f, _movement.z) * movementSpeed * Time.fixedDeltaTime);
        
        
    }
}

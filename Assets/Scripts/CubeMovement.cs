using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeMovement : MonoBehaviour
{
    private Rigidbody rb; // Reference to the Rigidbody component

    Animator animator;

    public float speed = 0.5f; // Adjust speed as needed
    public float jumpForce = 5f; // Adjust jump force as needed
    private bool isGrounded; // Check if the cube is grounded



    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to the cube
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input direction
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new(moveHorizontal, 0.0f, moveVertical);

        // Apply movement directly to the transform's position
        transform.Translate(speed * Time.deltaTime * movement);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            // Apply vertical force for jumping
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false; // Set grounded to false
        }
    }
    // Check if the cube collides with the ground
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            isGrounded = true; // Set grounded to true
        }
    }

    // Check if the cube leaves the ground
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Terrain")
        {
            isGrounded = false; // Set grounded to false
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody body;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
            move += Vector3.forward;        
        if (Input.GetKey(KeyCode.A))
            move += Vector3.left;
        if (Input.GetKey(KeyCode.S))
            move += Vector3.back;
        if (Input.GetKey(KeyCode.D))
            move += Vector3.right;

        move.Normalize();
        body.AddRelativeForce(move * speed);
        body.AddRelativeForce(-move * body.velocity.magnitude);
    }
}

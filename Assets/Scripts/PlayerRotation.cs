using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public GameObject player;
    public GameObject head;
    private float horAngle = 0;
    private float verAngle = 0;
    public float rotationSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;       
    }

    // Update is called once per frame
    void Update()
    {
        horAngle += Input.GetAxis("Mouse X") * rotationSpeed;
        verAngle += Input.GetAxis("Mouse Y") * rotationSpeed;

        player.transform.rotation = Quaternion.Euler(0, horAngle, 0);
        head.transform.rotation = Quaternion.Euler(-verAngle, horAngle, 0);
        
    }
}

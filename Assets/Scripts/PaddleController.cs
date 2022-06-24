using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode up;
    public KeyCode left;
    public KeyCode right;
    public KeyCode down;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 movement = GetInput();

        MoveObject(movement);
    }


    private Vector3 GetInput()
    {
        if (Input.GetKey(up))
        {
            return Vector3.forward * speed;
        }
        else if (Input.GetKey(down))
        {
            return Vector3.back * speed;
        }
        else if (Input.GetKey(left))
        {
            return Vector3.left * speed;   
        }
        else if (Input.GetKey(right))
        {
            return Vector3.right * speed;
        }

        return Vector3.zero;
    }

    // Function to move the object
    private void MoveObject(Vector3 movement)
    {
        rb.velocity = movement;
    }
}

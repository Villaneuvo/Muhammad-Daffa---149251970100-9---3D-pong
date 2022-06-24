using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();  

        rb.velocity = speed;  
    }

    private void Update() {

    }


}

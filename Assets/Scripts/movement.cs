using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    Rigidbody2D rb;
    public float thrust;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetKey("w")) {
            rb.AddForce(transform.up * thrust);
        }
        if (Input.GetKey("a")) {
            transform.Rotate(0, 0, 1f * rotationSpeed);
        }
        if (Input.GetKey("s")) {
            rb.AddForce(-transform.up * thrust);
        }
        if (Input.GetKey("d")) {
            transform.Rotate(0, 0, -1f * rotationSpeed);
        }
    }
}

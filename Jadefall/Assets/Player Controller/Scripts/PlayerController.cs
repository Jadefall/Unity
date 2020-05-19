using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 x;
    public Transform cam;
    public Vector3 y;
    public float speed;
    public float camsmooth;
    public Vector3 Jump;
    public float jumpMultiplier = 2.0f;
    public bool isGrounded;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);

        y.x = -Input.GetAxis("Mouse Y");
        x.y = Input.GetAxis("Mouse X");
        cam.Rotate(y * Time.deltaTime * camsmooth);
        transform.Rotate(x * Time.deltaTime * camsmooth);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Jump * jumpMultiplier, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}

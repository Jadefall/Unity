﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 Jump;
    public Transform cam;
    public float speedMultiplier = 5f;
    public float jumpMultiplier;
    public bool isGrounded;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speedMultiplier, 0, Input.GetAxis("Vertical") * Time.deltaTime * speedMultiplier);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Jump * jumpMultiplier, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
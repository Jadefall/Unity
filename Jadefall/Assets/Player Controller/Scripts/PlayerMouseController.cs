using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseController : MonoBehaviour
{
    public float mouseSensitivity = 400f;

    public Transform playerBody;

    public Rigidbody cast;

    float xRotation = 0f;
    float mouseX = 0f;
    float mouseY = 0f;
    public float cooldown = 2.0f;
    public bool canFire;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -60, 60);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);


        if (Input.GetButtonDown("Fire1") && canFire == true)
        {
            Rigidbody p = Instantiate(cast, transform.position + (transform.forward * 2), transform.rotation);
            cooldown = 2.0f;
        }

        cooldown -= Time.deltaTime;

        if (cooldown > 0)
        {
            canFire = false;
        }
        if (cooldown < 0)
        {
            canFire = true;
        }
    }
}

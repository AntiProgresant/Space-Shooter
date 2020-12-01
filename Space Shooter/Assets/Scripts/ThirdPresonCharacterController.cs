using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPresonCharacterController : MonoBehaviour
{
    public float Speed;
    public float maxSpeed = 6f;
    public Rigidbody rb;
    public float forwardForce = 200;
   
    void FixedUpdate()
    {
        PlayerMovement();

    }

    void PlayerMovement()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }
}

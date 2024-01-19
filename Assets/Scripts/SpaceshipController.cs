using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    Rigidbody rb;
    public float rocketForce;
    public float turningSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            VerticalMovement(1);

        if(Input.GetKey(KeyCode.LeftShift))
            VerticalMovement(-1);

        if(Input.GetKey(KeyCode.A))
            Turning(-1);

        if (Input.GetKey(KeyCode.D))
            Turning(1);
        
        if (Input.GetKey(KeyCode.W))
            HorizontalMovement(1);
        
        if (Input.GetKey(KeyCode.S))
            HorizontalMovement(-1);
    }

    void VerticalMovement(int _dir)
    {
        rb.AddRelativeForce(_dir * rocketForce * Vector3.up);
    }

    void HorizontalMovement(int _dir)
    {
        rb.AddRelativeForce(_dir * rocketForce * Vector3.forward);
    }

    void Turning(int _dir)
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, _dir * turningSpeed * Time.deltaTime, 0));
    }
}

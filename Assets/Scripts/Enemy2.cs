using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Rigidbody rbComponent;


    // Start is called before the first frame update
    void Start()
    {
        rbComponent = GetComponent<Rigidbody>();
        rbComponent.AddForce(Vector3.right * 0.5f, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (rbComponent.position.x < 22 && rbComponent.velocity.x <= 0)
        {
            rbComponent.AddForce(Vector3.right * 0.5f, ForceMode.VelocityChange);
        }

        if (rbComponent.position.x > 25 && rbComponent.velocity.x >= 0)
        {
            rbComponent.AddForce(Vector3.left * 0.5f, ForceMode.VelocityChange);
        }
    }
}

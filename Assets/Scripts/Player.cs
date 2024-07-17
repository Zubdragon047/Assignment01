using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyPressed = false;
    private float horizInput;
    private Rigidbody rbComponent;

    [SerializeField] private Transform groundCheckTransform = null;
    [SerializeField] private LayerMask playerMask;

    // Start is called before the first frame update
    private void Start()
    {
        rbComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyPressed = true;
        }

        horizInput = Input.GetAxis("Horizontal");
    }

    // Physics update
    private void FixedUpdate()
    {
        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        if (jumpKeyPressed)
        {
            rbComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyPressed = false;
        }

        rbComponent.velocity = new Vector3(horizInput, rbComponent.velocity.y, 0);
    }
}

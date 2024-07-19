using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private bool jumpKeyPressed = false;
    private float horizInput;
    private Rigidbody rbComponent;
    public int playerScore;

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
        rbComponent.velocity = new Vector3(horizInput, rbComponent.velocity.y, 0);

        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0)
        {
            return;
        }

        if (jumpKeyPressed)
        {
            rbComponent.AddForce(Vector3.up * 7, ForceMode.VelocityChange);
            jumpKeyPressed = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            Destroy(other.gameObject);
            playerScore++;
        }

        if (other.gameObject.layer == 8)
        {
            Destroy(other.gameObject);
            playerScore--;
        }
    }
}

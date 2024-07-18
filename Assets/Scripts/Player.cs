using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidBodyComponent;

    // private int Coin = 0;

    // public TextMeshProUGUI coinText;

   // private int superJumpsRemaining;

    [SerializeField] private Transform groundCheck;


    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //make player jump when space bar is pressed down
        if(Input.GetKeyDown(KeyCode.Space)){
              jumpKeyWasPressed = true;
        }

        //feeding in horizontal input every frame (if not pressed then feeds 0)
        horizontalInput = Input.GetAxis("Horizontal");
    }

    //fixed update is called once every physic update
    private void FixedUpdate()
    {
        rigidBodyComponent.velocity = new Vector3(horizontalInput,  rigidBodyComponent.velocity.y, 0);

        // if(!isGrounded){
        //     return;
        // }

        //if length is zero then in the air
        if(Physics.OverlapSphere(groundCheck.position, 0.1f).Length == 1)
        {
            return;
        }

         //make player jump when space bar is pressed down
        if(jumpKeyWasPressed){
           // float jumpPower = 5;
            // if(superJumpsRemaining > 0){
            //     jumpPower *= 2;
            //     superJumpsRemaining--;
            // }
              rigidBodyComponent.AddForce(Vector3.up * 7, ForceMode.VelocityChange);
              jumpKeyWasPressed = false;
        }

        
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if(other.gameObject.layer == 6)
    //     {
    //         Destroy(other.gameObject);
    //         Coin++;
    //         coinText.text = "Coin: " + Coin.ToString();
    //     }

    //     //add score here

    // }
//    private void OnCollisionEnter(Collision collision)
//     {
//         isGrounded = true;
//     }

//     private void OnCollisionExit(Collision collision)
//     {
//         isGrounded = false;
//     }


}

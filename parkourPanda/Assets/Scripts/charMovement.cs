using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement : MonoBehaviour{
    public float Speed = 10;
    public float Walk = 5;
    public Rigidbody rb;
    public float JumpForce = 10;
    public bool isGrounded = true;
    

    void Update(){
        PlayerMovement();
        Jump();
    }

    void PlayerMovement(){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        rb = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
        else
        {
            Vector3 playerMovement = new Vector3(hor, 0f, ver) * Walk * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
    }
    void Jump(){
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector3(0f, JumpForce, 0f), ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "ground"){
            isGrounded = true;
        }
    }
}

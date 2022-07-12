using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement : MonoBehaviour{
    public float Speed = 10;
    public float Walk = 5;
    public Rigidbody rb;
    public float JumpForce = 10;
    public bool isGrounded = true;
    public bool doubleJump = false;
    Lights lighting;
    public GameObject beamLight;
    public GameObject particle_effects; 
    public ParticleSystem particles; 
    
    public void Start(){
        particles = particle_effects.GetComponent<ParticleSystem>();
    }
    
    void Awake()
    {
        lighting = beamLight.GetComponent<Lights>();
    }
    

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
            FindObjectOfType<soundManager>().Play("jump");
            doubleJump = true;
            particles.Emit(1);
            particles.Play();
        }
        else if(Input.GetButtonDown("Jump") && doubleJump){
            rb.AddForce(new Vector3(0f, JumpForce, 0f), ForceMode.Impulse);
            FindObjectOfType<soundManager>().Play("doubleJump");
            doubleJump = false;
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "goodGrass"){

            isGrounded = true;
            FindObjectOfType<soundManager>().Play("grassSound");
            lighting.lightsOn(true);
            particles.Stop();
        }
        else if(other.tag == "ground"){

            isGrounded = true;
            FindObjectOfType<soundManager>().Play("grassSound");
            lighting.lightsOn(false);
            particles.Stop();
        }
        else if(other.tag == "killGrass"){
            doubleJump = false;
            FindObjectOfType<soundManager>().Play("grassSound");
            lighting.lightsOn(true);
        }
        else if(other.tag == "sender"){

            isGrounded = true;
            FindObjectOfType<soundManager>().Play("grassSound");
            lighting.lightsOn(true);
        }
        else if(other.tag == "receiver"){

            isGrounded = true;
            FindObjectOfType<soundManager>().Play("grassSound");
            lighting.lightsOn(true);
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        lighting.lightsOn(false);
    }
    

}

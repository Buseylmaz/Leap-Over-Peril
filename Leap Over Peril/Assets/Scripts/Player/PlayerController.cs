using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;


    Animator animator;

    [SerializeField] float jumpSpeed;
    [SerializeField] bool isGround = true;

    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && isGround==true)
        {
            
            rigidbody.AddForce(Vector3.up * jumpSpeed , ForceMode.Impulse);
            animator.SetTrigger("Jump_trig");

            isGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}

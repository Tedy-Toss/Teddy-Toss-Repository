using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float speed = 40f;
    

    float horizontalMove = 0f;
    bool jump = false;
    bool Crouch = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")* speed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if(Input.GetButtonDown("Crouch"))
        {
            Crouch = true;
            

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            Crouch = false;
           
        }
    }

    public void OnClickright()
    {
        horizontalMove = 1 * speed;
        Debug.Log(horizontalMove);
    }
    public void OnClickleft()
    {
        horizontalMove = -1 * speed;
        Debug.Log(horizontalMove);
    }
    public void OnClickstop()
    {
        horizontalMove = 0 * speed;
        Debug.Log(horizontalMove);
    }
    public void OnClickJump()
    {
        jump = true;
        animator.SetBool("IsJumping", true);
    }
    public void OnClickCrouch()
    {
        Crouch = true;
    }
    public void OnClickunCrouch()
    {
        Crouch = false;
    }


    public void OnDucking(bool isDucking)
    {
        animator.SetBool("IsDucking", isDucking);
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        Debug.Log("trigger");
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, Crouch, jump);
        jump = false;
    }
    
}

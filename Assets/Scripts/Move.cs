using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]
public class Move : MonoBehaviour
{
    //karakter hareketi
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 10;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        if (characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * rotationSpeed * hInput;
            if(Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
            }
        }
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hi");
    }
}

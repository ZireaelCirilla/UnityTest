using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movimiento : MonoBehaviour {

    private Rigidbody rb;
    public float speed = 1.0f;
    private float movementUp;
    public float jumpForce = 1.0f;
    private int jumpCounter = 0;
    public int maxJumps = 1;
    public GameObject cameraRotation;

    private Vector3 dirX = new Vector3(1, 0, 0);
    private Vector3 vxz;
    private Vector3 dirZ = new Vector3(0, 0, 1);

    public float cameraDegree;
    public float fX;
    public float fZ;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        fX = Mathf.Sin(cameraDegree);
        fZ = Mathf.Cos(cameraDegree);

        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        if(transform.position.y <= 0.51)
        {
            jumpCounter = 0;
        }

        movementUp = 0;

        if (Input.GetKeyDown(KeyCode.Space) && jumpCounter < maxJumps)
        {
            jumpCounter++;
            movementUp = jumpForce;
        }

        cameraDegree = cameraRotation.transform.eulerAngles.y;

         Vector3 movement = new Vector3(movementHorizontal, movementUp, movementVertical);
         rb.AddForce(movement * speed);

        /*vxz = new Vector3(1 * fX, movementUp, 1 * fZ);

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(dirZ * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-dirZ * speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-dirX * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(dirX * speed);
        }*/

    }
}

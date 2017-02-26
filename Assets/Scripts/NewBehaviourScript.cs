using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Rigidbody rb;
    public float speed;    
    float moveUp;
    public Camera playerCamera;
    public float rotationRight = 0;
    float movementSpeed = 10;
    void Start()

    {
        rb = GetComponent<Rigidbody>();    
    }


    void FixedUpdate()
    {     

        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0, moveUp, 0);
        rb.AddForce(movement * speed);

        playerCamera.transform.position = transform.position;

        


        if (Input.GetKeyDown("space"))
        {
            moveUp = 5;
            transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
            transform.rotation = Quaternion.AngleAxis(0, Vector3.right);
        }
        else
        {
            if (moveUp > -6)
            {
                moveUp = moveUp - .5f;
            }
            else
            {
                // because it's already falling fast, do nothing
            }
        }
    }

}

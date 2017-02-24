using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    float moveUp;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveUp, moveVertical);
        rb.AddForce(movement * speed);

        if (Input.GetKeyDown("space"))
        {
            moveUp = 5;  


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

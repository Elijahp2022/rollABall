using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
    public bool position;
    Vector3 threeview = new Vector3();
    float angle = 45;
    float rotationRight = 0;
    float rotationLeft = 0;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        transform.rotation = Quaternion.AngleAxis(45f, Vector3.right);

    }
	
	// Update is called once per frame
	void LateUpdate () {


        if (position == true)
        {
            //third person view
            transform.position = player.transform.position + offset;
            transform.rotation = Quaternion.AngleAxis(45f, Vector3.right);


        }   
        else
        {
            //first person view
            transform.position = player.transform.position;
            if(transform.rotation.x != 0)
            {
                print("transform.rotation is not zero!!!");
                transform.rotation = Quaternion.AngleAxis(player.transform.rotation.y, Vector3.up);
            }


            if (Input.GetKey(KeyCode.L))
            {
                transform.Rotate(0, 1, 0);
            }

            if (Input.GetKey(KeyCode.J))
            {
                transform.Rotate(0, -1, 0);
            }
            transform.rotation = player.transform.rotation;


        }
	}
}

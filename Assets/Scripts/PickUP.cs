using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.tag = "Pick up";
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3 (-50, 0, 50) * Time.deltaTime);
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCameraSwitch : MonoBehaviour {
    public Camera mainCamera;
    public Camera playerCamera;

    // Use this for initialization
    void Start () {
        mainCamera.enabled = true;
        playerCamera.enabled = false;
    }

	// Update is called once per frame
	void Update () {
        //This will toggle the enabled state of the two cameras between true and false each time
        if (Input.GetKeyUp(KeyCode.Return))
        {
            mainCamera.enabled = !mainCamera.enabled;
            playerCamera.enabled = !playerCamera.enabled;
        }
    }
    
}

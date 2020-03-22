﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate() {
        handlePlaneForwardMovement();   

        handlePlaneTiltByPlayerInput();
    }

    private void handlePlaneForwardMovement() {
        var speed = 15;

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void handlePlaneTiltByPlayerInput()  {
        var verticalInput = Input.GetAxis("Vertical");
        var tiltSpeed = 20;

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * tiltSpeed * Time.deltaTime * verticalInput);
    }
}

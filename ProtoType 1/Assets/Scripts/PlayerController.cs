using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVehicleForwardByPlayerInput();
        rotateVehicleByPlayerInput();
    }

    private float verticalInput;
    private float speed = 15.0f;

    private void moveVehicleForwardByPlayerInput() {
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }

    private float turnspeed = 40.0f;
    private float horizontalInput;

    private void rotateVehicleByPlayerInput() {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);
    }
}

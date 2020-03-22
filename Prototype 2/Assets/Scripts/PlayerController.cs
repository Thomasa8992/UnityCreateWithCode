using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float movementSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        var leftBoundary = -10;

        if(transform.position.x < leftBoundary) {
            transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
        }

        var rightBoundary = 10;

        if(transform.position.x > rightBoundary) {
            transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
        }

        handleMovementByPlayerInput();
    }

    private void handleMovementByPlayerInput() {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * movementSpeed);
    }
}

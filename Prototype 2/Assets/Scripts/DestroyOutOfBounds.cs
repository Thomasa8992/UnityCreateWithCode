using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBoundary = 30;
    public float lowerBoundary = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        handleOutOfBoundsObject();
    }

    private void handleOutOfBoundsObject() {
        var foodIsOutOfBounds = transform.position.z > topBoundary;
        var animalIsOuOfBounds = transform.position.z < lowerBoundary;

        if (foodIsOutOfBounds) {
            Destroy(gameObject);
        } 
        else if (animalIsOuOfBounds) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }


}   

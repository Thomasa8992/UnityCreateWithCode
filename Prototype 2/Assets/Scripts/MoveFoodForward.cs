using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoodForward : MonoBehaviour
{
    public float movementSpeed = 40.0f;
    public float rotateAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateAngle = 1;

        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }   
}

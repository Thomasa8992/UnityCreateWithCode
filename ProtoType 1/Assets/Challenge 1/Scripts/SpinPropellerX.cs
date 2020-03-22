using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        handlePropellorRotation();
    }

    private void handlePropellorRotation() {
        var propellerSpinSpeed = 300.0f;
        var propellerRotation = new Vector3(0, 0, 1);

        transform.Rotate(propellerRotation * Time.deltaTime * propellerSpinSpeed);
    }
}

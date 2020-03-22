using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update() {
        handleCameraPositionRelativeToPlanePosition();
    }

    private void handleCameraPositionRelativeToPlanePosition() {
       var offset = new Vector3(32, 0, 0);

        transform.position = plane.transform.position + offset;
    }
}

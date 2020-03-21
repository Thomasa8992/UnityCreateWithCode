using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setUpCameraPosition();
    }

    private void setUpCameraPosition() {
        var cameraOffsetPosition = new Vector3(0, 5, -7);

        transform.position = player.transform.position + cameraOffsetPosition;
    }
}

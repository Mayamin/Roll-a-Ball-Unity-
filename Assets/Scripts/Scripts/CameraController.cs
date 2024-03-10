using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    //private because its value can be changed from here
    private Vector3 offset;

    //find current camera position and subttract it from the position of the player
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Late Update is guaranteed to run after processing and updating everytihing or tasks in each frame update
    void LateUpdate()
    {
        //camera moves with object (moving due to camera controls) at a certain offset now
        transform.position = player.transform.position + offset;
    }
}


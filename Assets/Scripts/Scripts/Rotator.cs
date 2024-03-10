using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    { 
        //multiply it with delta time to make rotation smooth and frame rate independent
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
    }
}

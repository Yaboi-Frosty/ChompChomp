using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraLook : MonoBehaviour
{
    public float verticalspeed;

    // Update is called once per frame
    void Update()
    {
        float v = verticalspeed * Input.GetAxis("Mouse Y") * -1;
        //move camera
        transform.Rotate(v, 0, 0);
    }
}

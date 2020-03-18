using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFirstPerson : MonoBehaviour
{
    public float Speed;

    public float horizontalspeed; //the rate we rotate towards mouse
    public float verticalspeed;

    // Update is called once per frame
    void Update()
    {
        //get the mouse delta.
        float h = horizontalspeed * Input.GetAxis("Mouse X");
        //float v = verticalspeed * Input.GetAxis("Mouse Y") * -1;
        //move camera
        transform.Rotate(0, h, 0);

        //player movement

        float Vtranslation = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        float Htranslation = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        //apply the axis values to a translate to move object.
        transform.Translate(Htranslation, 0, Vtranslation);


    }
}

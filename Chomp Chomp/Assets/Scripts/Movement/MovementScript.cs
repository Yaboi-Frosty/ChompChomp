using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public GameObject Player;
    public float Speed;
    public float Sprint;

    private float walkSpeed;

    private void Start()
    {
        walkSpeed = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        //move on a fixed axis

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime,Space.Self);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime, Space.Self);
        }

        /*
        //returns a value between -1 and 1, then multiplies by speed
        float Vtranslation = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        float Htranslation = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;

        //apply the axis values to a translate to move object.
        transform.Translate(Htranslation, 0, Vtranslation, Space.World);
        */

        //sprint toggle
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = Sprint;
        }
        else
        {
            Speed = walkSpeed;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Nicearu");
    }
}

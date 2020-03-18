using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOnRotate : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {

        float Vtranslation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, Vtranslation);

        if (Vtranslation != 0)
        {
            transform.Rotate(0, rotation, 0);
        }
    }
}

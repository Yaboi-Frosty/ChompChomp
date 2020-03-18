using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGateDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(other.transform.localScale);

            if (other.transform.localScale == new Vector3(1.5f, 1.5f, 1.5f))
            {
                gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

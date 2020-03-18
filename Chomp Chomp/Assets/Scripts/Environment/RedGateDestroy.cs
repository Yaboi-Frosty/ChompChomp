using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGateDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(other.transform.localScale);

            if (other.transform.localScale == new Vector3(1f, 1f, 1f))
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

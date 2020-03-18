using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaledAttack : MonoBehaviour


{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.localScale.sqrMagnitude);
        Debug.Log(transform.localScale.sqrMagnitude);

        if (other.gameObject.CompareTag("Enemy"))
        { 

        if (other.transform.localScale.sqrMagnitude < transform.localScale.sqrMagnitude)
            {
                //Destroy gameObject 
                other.gameObject.SetActive(false);
            }
            else
            {
                //Destroy gameObject 
                gameObject.SetActive(false);

            }
        //Increase player size when 'eating' pick up
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}

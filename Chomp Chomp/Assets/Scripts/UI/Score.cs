using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;        // The player's score.


    Text text;                      // Reference to the Text component.
     

    void Start()
    {
        // Set up the reference.
        text = transform.Find("Text").GetComponent<Text>();

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy)")
        {
            score++;
        }
    }
}

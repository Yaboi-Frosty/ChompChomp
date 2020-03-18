using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionScore : MonoBehaviour
{
    public GameObject player;
    public GameObject scoremanager;

void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        scoremanager = GameObject.Find("CurrentScore");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            Debug.Log("hit");

            scoremanager.GetComponent<CurrentScore>().score += 1;
            Destroy(gameObject);
        }
    }
}

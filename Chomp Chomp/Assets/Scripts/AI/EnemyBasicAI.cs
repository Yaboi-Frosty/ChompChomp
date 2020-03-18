using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyBasicAI : MonoBehaviour
{
    public GameObject Player;
    public NavMeshAgent agent;

    public string state; // the state of the enemies behaviour

    // Start is called before the first frame update
    void Start()
    {
        state = "idle";
    }

    // Update is called once per frame
    void Update()
    {
        if (state == "chase")
        {
            agent.SetDestination(Player.transform.position);
        }

    }

    //check if player has entered range
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            state = "chase";
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            agent.SetDestination(agent.transform.position);
            state = "idle";

        }
    }


}
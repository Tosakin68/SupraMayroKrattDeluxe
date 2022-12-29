using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform destination;
    GameObject cor;
    NavMeshPath path;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cor = GameObject.FindGameObjectWithTag("Coordination");
    }

    void Update()
    {
        cor = GameObject.FindGameObjectWithTag("Coordination");
        agent.SetDestination(cor.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coordination"))
        {
            Invoke("SearchForNewDestination", 1.0f);
        }
    }

    void SearchForNewDestination()
    {
        cor = GameObject.FindGameObjectWithTag("Coordination");
    }
}

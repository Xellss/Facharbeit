using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour
{

    public Transform Goal;
    private NavMeshAgent agent;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = Goal.position;
    }

    void Update()
    {
          agent.destination = Goal.position;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToPosition : MonoBehaviour
{
    [SerializeField] Transform movePositionTransform;

    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Villager : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] LayerMask groundLayer;
    Vector3 destPoint;
    bool walkpointSet;

    string lastPoint = "point2";

    public Transform point1;
    public Transform point2;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!walkpointSet) SearchForDest();
        if (walkpointSet) agent.SetDestination(destPoint);
        if (Vector3.Distance(transform.position, destPoint) < 3) walkpointSet = false;
    }

    void SearchForDest()
    {
        if (lastPoint == "point1") {
            destPoint = point2.position;
            lastPoint = "point2";
        }
        else if (lastPoint == "point2") {
            destPoint = point1.position;
            lastPoint = "point1";
        }

        if (Physics.Raycast(destPoint, Vector3.down, groundLayer)) {
            walkpointSet = true;
        }
    }
}

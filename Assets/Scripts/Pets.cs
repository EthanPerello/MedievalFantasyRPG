using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Pets : MonoBehaviour
{
    GameObject player;
    NavMeshAgent agent;
    [SerializeField] LayerMask groundLayer, playerLayer;

    Vector3 destPoint;
    bool walkpointSet;
    [SerializeField] float range;

    bool followPlayer = true;

    Animator animator;

    float waitRange = 2;
    bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInRange = Physics.CheckSphere(transform.position, waitRange, playerLayer);
        if (!followPlayer) Wander();
        if (followPlayer){
            if (playerInRange) Wait();
            else Chase();
        }
    }

    void Chase() {
        animator.SetBool("Walk", true);
        destPoint = new Vector3(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z - 1);
        agent.SetDestination(destPoint);
    }

    void Wait() {
        animator.SetBool("Walk", false);
    }

    void Wander()
    {
        if (!walkpointSet) SearchForDest();
        if (walkpointSet) agent.SetDestination(destPoint);
        if (Vector3.Distance(transform.position, destPoint) < 10) walkpointSet = false;
    }

    void SearchForDest()
    {
        float z = Random.Range(-range,range);
        float x = Random.Range(-range,range);

        destPoint = new Vector3(transform.position.x + x, transform.position.y,transform.position.z + z);

        if (Physics.Raycast(destPoint, Vector3.down, groundLayer)) {
            walkpointSet = true;
        }
    }
}

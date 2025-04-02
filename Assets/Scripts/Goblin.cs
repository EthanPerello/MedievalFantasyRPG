using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Goblin : MonoBehaviour
{
    GameObject player;
    NavMeshAgent agent;
    [SerializeField] LayerMask groundLayer, playerLayer;

    Animator animator;

    Vector3 destPoint;
    bool walkpointSet;
    [SerializeField] float range;

    [SerializeField] float sightRange, attackRange;
    bool playerInSight, playerInAttackRange;

    public GameObject weapon;
    Collider attackCollider;

    public Image healthBar;

    private float health = 30;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        animator = GetComponent<Animator>();
        attackCollider = weapon.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, playerLayer);

        if (!playerInSight && !playerInAttackRange) Wander();
        if (playerInSight && !playerInAttackRange) Chase();
        if (playerInAttackRange) Attack();

        if (health <= 0) {
            StartCoroutine(death());
        }

        healthBar.fillAmount = health / 30;
    }

    void Chase() {
        agent.SetDestination(player.transform.position);
    }

    void Attack() {
        agent.SetDestination(transform.position);
        transform.LookAt(player.transform);
        animator.SetTrigger("Attack");
        attackCollider.enabled = true;
        StartCoroutine(waiter());
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

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Weapon") {
            health -= PlayerInfo.damage;
            animator.SetTrigger("TakeDamage");
            if (Inventory.weapon == "Bow") {
                Destroy(other.gameObject);
            }
        }
    }

    IEnumerator waiter()
    {   yield return new WaitForSecondsRealtime(1);
        attackCollider.enabled = false;
    }

    IEnumerator death() {
        animator.SetTrigger("Dead");
        yield return new WaitForSecondsRealtime(2);
        GoblinSpawner.goblins -= 1;
        Destroy(gameObject);
        if (Quests.quest1Accepted == true) {
                Quests.goblinsKilled += 1;
        }
        PlayerInfo.currentExp += 10;
    }
}

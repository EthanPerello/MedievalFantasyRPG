using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class GoblinKing : MonoBehaviour
{
    GameObject player;
    NavMeshAgent agent;
    [SerializeField] LayerMask groundLayer, playerLayer;

    Animator animator;

    [SerializeField] float sightRange, attackRange;
    bool playerInSight, playerInAttackRange;

    public GameObject weapon;
    Collider attackCollider;

    public Image healthBar;

    public static float health = 100;
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

        if (playerInSight && !playerInAttackRange) Chase();
        if (playerInAttackRange) Attack();

        if (health <= 0) {
            StartCoroutine(death());
        }

        if (Quests.quest2Accepted == false) {
            gameObject.SetActive(false);
        }

        healthBar.fillAmount = health / 100;
    }

    void Chase() {
        animator.SetBool("Walk", true);
        agent.SetDestination(player.transform.position);
    }

    void Attack() {
        agent.SetDestination(transform.position);
        transform.LookAt(player.transform);
        animator.SetTrigger("Attack");
        attackCollider.enabled = true;
        StartCoroutine(waiter());
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Weapon") {
            health -= PlayerInfo.damage;
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
        if (Quests.quest2Accepted == true) {
            Quests.goblinKingKilled = true;
        }
        PlayerInfo.killedGoblinKing = true;
        gameObject.SetActive(false);
        PlayerInfo.currentExp += 100;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTakeDamage : MonoBehaviour
{
    private Animator animator;

    void Start() {
        animator = GetComponent<Animator>();
    }

    void Update() {
        if (PlayerInfo.health <= 0) {
            PlayerInfo.gold = 0;
            PlayerInfo.health = 100;
            SceneManager.LoadScene("Village");
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "GoblinWeapon") {
            PlayerInfo.health -= 10 * ((100 - PlayerInfo.defense) / 100);
            animator.SetTrigger("TakeDamage");
        }
        if (other.tag == "GoblinKingWeapon") {
            PlayerInfo.health -= 25 * ((100 - PlayerInfo.defense) / 100);
            animator.SetTrigger("TakeDamage");
        }
        if (other.tag == "SkeletonWeapon") {
            PlayerInfo.health -= 15 * ((100 - PlayerInfo.defense) / 100);
            animator.SetTrigger("TakeDamage");
        }
    }
}

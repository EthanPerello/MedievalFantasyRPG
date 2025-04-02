using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerClick : MonoBehaviour
{
    public Camera cam;
    public Animator bowAnimator;
    private Animator animator;
    private Collider attackColliderBronze;
    private Collider attackColliderSilver;
    private Collider attackColliderGold;
    public GameObject bronzeSword;
    public GameObject silverSword;
    public GameObject goldSword;
    private bool shooting = false;
    public GameObject arrowObject;
    public Transform arrowPoint;
    public static bool attacking = false;
    public static bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        attacking = false;
        animator = GetComponent<Animator>();
        attackColliderBronze = bronzeSword.GetComponent<Collider>();
        attackColliderSilver = silverSword.GetComponent<Collider>();
        attackColliderGold = goldSword.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && grounded == true) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.name == "Villager") {
                    SceneManager.LoadScene("Interaction");

                    if (Quests.quest0Accepted == true) {
                        Quests.villagerClicked = true;
                    }
                }
            }

            if (Inventory.weapon != "Bow") {
                if (attackColliderBronze.enabled == false && attackColliderSilver.enabled == false && attackColliderGold.enabled == false) {
                    attacking = true;
                    animator.SetTrigger("Attack");
                    attackColliderBronze.enabled = true;
                    attackColliderSilver.enabled = true;
                    attackColliderGold.enabled = true;
                    StartCoroutine(attack());
                }
            }
            else {
                if (shooting == false) {
                    attacking = true;
                    animator.SetTrigger("BowShot");
                    bowAnimator.SetTrigger("Shot");
                    shooting = true;
                    GameObject arrow = Instantiate(arrowObject, arrowPoint.position, transform.rotation);
                    arrow.GetComponent<Rigidbody>().AddForce(transform.forward * 25f, ForceMode.Impulse);
                    arrow.GetComponent<Rigidbody>().AddForce(transform.up * 5f, ForceMode.Impulse);
                    StartCoroutine(bowshot());
                }
            }
        }
    }

    IEnumerator attack()
    {   yield return new WaitForSecondsRealtime(0.867f);
        attackColliderBronze.enabled = false;
        attackColliderSilver.enabled = false;
        attackColliderGold.enabled = false;
        attacking = false;
    }
    IEnumerator bowshot()
    {   yield return new WaitForSecondsRealtime(0.967f);
        shooting = false;
        attacking = false;
    }
}

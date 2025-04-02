using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private float fullHealth = 100;
    private float currentHealth = PlayerInfo.health;
    private Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = PlayerInfo.health;
        healthBar.fillAmount = currentHealth / fullHealth;
    }
}

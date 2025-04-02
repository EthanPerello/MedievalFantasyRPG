using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    public static float health = 100;
    public static float baseAttack = 0;
    public static float baseDefense = 0;
    public static float level = 0;
    public static float currentExp = 0;
    public static float expToNextLevel = (100 * level) + 100;
    public static float defense = 0;
    public static float weaponDamage = 10;
    public static float gold = 500;
    public static float healthPotions = 0;
    public static bool hasSilverSword = false;
    public static bool hasGoldSword = false;
    public static bool hasBow = false;
    public static bool hasIronHelmet = false;
    public static bool hasIronArmor = false;
    public static bool hasDog = true;
    public static bool killedGoblinKing = false;
    public static float helmetDefense = 0;
    public static float armorDefense = 0;

    RememberPosition playerPosData;

    public static float damage;

    private void Awake() {
        playerPosData = FindFirstObjectByType<RememberPosition>();
        playerPosData.PlayerPosLoad();
    }

    // Update is called once per frame
    void Update()
    {
        damage = baseAttack + weaponDamage;
        defense = helmetDefense + armorDefense + baseDefense;

        if (currentExp >= expToNextLevel) {
            level += 1;
            health = 100;
            baseAttack += 1;
            baseDefense += 1;
            currentExp = 0;
            expToNextLevel = (100 * level) + 100;
            LevelUp.previousScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("LevelUp");
        }
    }
}

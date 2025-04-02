using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Inventory : MonoBehaviour
{
    public static string previousScene;
    
    public TMPro.TextMeshProUGUI goldText;
    public TMPro.TextMeshProUGUI potionText;
    public GameObject noHelmetText;
    public GameObject noArmorText;
    public GameObject ironHelmet;
    public GameObject ironArmor;
    public GameObject equipIronHelmetButton;
    public GameObject equipIronArmorButton;
    public GameObject ironHelmetIcon;
    public GameObject ironArmorIcon;

    public GameObject noPetText;
    public GameObject dog;
    public GameObject equipDogButton;
    public GameObject dogIcon;

    //weapons
    public GameObject bronzeToSilverButton;
    public GameObject bronzeToGoldButton;
    public GameObject bronzeToBowButton;
    public GameObject silverToBronzeButton;
    public GameObject silverToGoldButton;
    public GameObject silverToBowButton;
    public GameObject goldToBowButton;
    public GameObject goldToBronzeButton;
    public GameObject equipBronzeSwordButton;
    public GameObject equipSilverSwordButton;
    public GameObject equipGoldSwordButton;
    public GameObject equipBowButton;
    public GameObject bronzeSwordIcon;
    public GameObject silverSwordIcon;
    public GameObject goldSwordIcon;
    public GameObject bowIcon;

    public static string weapon = "BronzeSword";
    public static string helmet = "None";
    public static string armor = "None";
    public static string pet = "None";

    public void ExitInventory() {
        GoblinSpawner.goblins = 0;
        SceneManager.LoadScene(previousScene);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = "Gold: " + Convert.ToString(PlayerInfo.gold);
        potionText.text = Convert.ToString(PlayerInfo.healthPotions);

        if (PlayerInfo.hasSilverSword == true && PlayerInfo.hasGoldSword == false && PlayerInfo.hasBow == false) {
            bronzeToSilverButton.SetActive(true);
            silverToBronzeButton.SetActive(true);
            if (weapon == "SilverSword") {
                silverSwordIcon.SetActive(true);
                equipSilverSwordButton.SetActive(false);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
                
            }
            if (weapon == "BronzeSword") {
                silverSwordIcon.SetActive(false);
                equipSilverSwordButton.SetActive(true);
                bronzeSwordIcon.SetActive(true);
                equipBronzeSwordButton.SetActive(false);
            }
        }
        if (PlayerInfo.hasSilverSword == false && PlayerInfo.hasGoldSword == true && PlayerInfo.hasBow == false) {
            bronzeToGoldButton.SetActive(true);
            if (weapon == "GoldSword") {
                goldSwordIcon.SetActive(true);
                equipGoldSwordButton.SetActive(false);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
            }
            if (weapon == "BronzeSword") {
                goldSwordIcon.SetActive(false);
                equipGoldSwordButton.SetActive(true);
                bronzeSwordIcon.SetActive(true);
                equipBronzeSwordButton.SetActive(false);
            }
        }
        if (PlayerInfo.hasSilverSword == true && PlayerInfo.hasGoldSword == true && PlayerInfo.hasBow == false) {
            bronzeToSilverButton.SetActive(true);
            silverToGoldButton.SetActive(true);
            if (weapon == "GoldSword") {
                goldSwordIcon.SetActive(true);
                silverSwordIcon.SetActive(false);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
                equipSilverSwordButton.SetActive(true);
                equipGoldSwordButton.SetActive(false);
            }
            if (weapon == "SilverSword") {
                goldSwordIcon.SetActive(false);
                silverSwordIcon.SetActive(true);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
                equipSilverSwordButton.SetActive(false);
                equipGoldSwordButton.SetActive(true);
            }
            if (weapon == "BronzeSword") {
                goldSwordIcon.SetActive(false);
                silverSwordIcon.SetActive(false);
                bronzeSwordIcon.SetActive(true);
                equipBronzeSwordButton.SetActive(false);
                equipSilverSwordButton.SetActive(true);
                equipGoldSwordButton.SetActive(true);
            }
        }
        if (PlayerInfo.hasSilverSword == false && PlayerInfo.hasGoldSword == false && PlayerInfo.hasBow == true) {
            bronzeToBowButton.SetActive(true);
            if (weapon == "Bow") {
                bowIcon.SetActive(true);
                equipBowButton.SetActive(false);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
            }
            if (weapon == "BronzeSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                bronzeSwordIcon.SetActive(true);
                equipBronzeSwordButton.SetActive(false);
            }
        }
        if (PlayerInfo.hasSilverSword == true && PlayerInfo.hasGoldSword == false && PlayerInfo.hasBow == true) {
            bronzeToSilverButton.SetActive(true);
            silverToBowButton.SetActive(true);
            if (weapon == "Bow") {
                bowIcon.SetActive(true);
                equipBowButton.SetActive(false);
                silverSwordIcon.SetActive(false);
                equipSilverSwordButton.SetActive(true);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
            }
            if (weapon == "SilverSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                silverSwordIcon.SetActive(true);
                equipSilverSwordButton.SetActive(false);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
                
            }
            if (weapon == "BronzeSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                silverSwordIcon.SetActive(false);
                equipSilverSwordButton.SetActive(true);
                bronzeSwordIcon.SetActive(true);
                equipBronzeSwordButton.SetActive(false);
            }
        }
        if (PlayerInfo.hasSilverSword == false && PlayerInfo.hasGoldSword == true && PlayerInfo.hasBow == true) {
            bronzeToGoldButton.SetActive(true);
            goldToBowButton.SetActive(true);
            if (weapon == "Bow") {
                bowIcon.SetActive(true);
                equipBowButton.SetActive(false);
                goldSwordIcon.SetActive(false);
                equipGoldSwordButton.SetActive(true);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
            }
            if (weapon == "GoldSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                goldSwordIcon.SetActive(true);
                equipGoldSwordButton.SetActive(false);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
            }
            if (weapon == "BronzeSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                goldSwordIcon.SetActive(false);
                equipGoldSwordButton.SetActive(true);
                bronzeSwordIcon.SetActive(true);
                equipBronzeSwordButton.SetActive(false);
            }
        }
        if (PlayerInfo.hasSilverSword == true && PlayerInfo.hasGoldSword == true && PlayerInfo.hasBow == true) {
            bronzeToSilverButton.SetActive(true);
            silverToGoldButton.SetActive(true);
            goldToBowButton.SetActive(true);
            if (weapon == "Bow") {
                bowIcon.SetActive(true);
                equipBowButton.SetActive(false);
                goldSwordIcon.SetActive(false);
                equipGoldSwordButton.SetActive(true);
                silverSwordIcon.SetActive(false);
                equipSilverSwordButton.SetActive(true);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
            }
            if (weapon == "GoldSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                goldSwordIcon.SetActive(true);
                silverSwordIcon.SetActive(false);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
                equipSilverSwordButton.SetActive(true);
                equipGoldSwordButton.SetActive(false);
            }
            if (weapon == "SilverSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                goldSwordIcon.SetActive(false);
                silverSwordIcon.SetActive(true);
                bronzeSwordIcon.SetActive(false);
                equipBronzeSwordButton.SetActive(true);
                equipSilverSwordButton.SetActive(false);
                equipGoldSwordButton.SetActive(true);
            }
            if (weapon == "BronzeSword") {
                bowIcon.SetActive(false);
                equipBowButton.SetActive(true);
                goldSwordIcon.SetActive(false);
                silverSwordIcon.SetActive(false);
                bronzeSwordIcon.SetActive(true);
                equipBronzeSwordButton.SetActive(false);
                equipSilverSwordButton.SetActive(true);
                equipGoldSwordButton.SetActive(true);
            }
        }

        if (PlayerInfo.hasIronHelmet == true) {
            ironHelmet.SetActive(true);
            noHelmetText.SetActive(false);
            if (helmet == "IronHelmet") {
                ironHelmetIcon.SetActive(true);
                equipIronHelmetButton.SetActive(false);
            }
            else {
                ironHelmetIcon.SetActive(false);
                equipIronHelmetButton.SetActive(true);
            }
        }
        if (PlayerInfo.hasIronArmor == true) {
            ironArmor.SetActive(true);
            noArmorText.SetActive(false);
            if (armor == "IronArmor") {
                ironArmorIcon.SetActive(true);
                equipIronArmorButton.SetActive(false);
            }
            else {
                ironArmorIcon.SetActive(false);
                equipIronArmorButton.SetActive(true);
            }
        }

        if (PlayerInfo.hasDog == true) {
            dog.SetActive(true);
            noPetText.SetActive(false);
            if (pet == "Dog") {
                dogIcon.SetActive(true);
                equipDogButton.SetActive(false);
            }
            else {
                dogIcon.SetActive(false);
                equipDogButton.SetActive(true);
            }
        }
    }

    public void UsePotion() {
        if (PlayerInfo.healthPotions >= 1) {
            PlayerInfo.health = 100;
            PlayerInfo.healthPotions -= 1;
        }
    }

    public void EquipBronzeSword() {
        weapon = "BronzeSword";
        PlayerInfo.weaponDamage = 10;
    }

    public void EquipSilverSword() {
        weapon = "SilverSword";
        PlayerInfo.weaponDamage = 15;
    }

    public void EquipGoldSword() {
        weapon = "GoldSword";
        PlayerInfo.weaponDamage = 20;
    }

    public void EquipBow() {
        weapon = "Bow";
        PlayerInfo.weaponDamage = 10;
    }

    public void EquipIronHelmet() {
        helmet = "IronHelmet";
        PlayerInfo.helmetDefense = 5;
    }

    public void EquipIronArmor() {
        armor = "IronArmor";
        PlayerInfo.armorDefense = 15;
    }

    public void UnequipIronHelmet() {
        helmet = "None";
        PlayerInfo.helmetDefense = 0;
    }

    public void UnequipIronArmor() {
        armor = "None";
        PlayerInfo.armorDefense = 0;
    }

    public void EquipDog() {
        pet = "Dog";
    }

    public void UnequipDog() {
        pet = "None";
    }
}

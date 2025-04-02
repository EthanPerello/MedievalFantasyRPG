using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class InteractionMenu : MonoBehaviour
{
    public GameObject acceptButton1;
    public GameObject acceptedText1;
    public GameObject acceptButton2;
    public GameObject acceptedText2;
    public GameObject completedText2;

    public TMPro.TextMeshProUGUI goldText;

    public GameObject buySilverSwordButton;
    public GameObject buyGoldSwordButton;
    public GameObject buyBowButton;
    public GameObject buyIronHelmetButton;
    public GameObject buyIronArmorButton;

    public GameObject chat;
    public TMPro.TextMeshProUGUI chatText;

    public TMPro.TextMeshProUGUI numPotionText;

    void Start(){

    }

    void Update() {
        //quests
        if (Quests.quest1Accepted == true) {
            acceptButton1.SetActive(false);
            acceptButton2.SetActive(false);
            acceptedText1.SetActive(true);
            chat.SetActive(true);
            chatText.text = "Use the map to travel to Goblin Land.";

        }
        else if (Quests.quest2Accepted == true) {
            acceptButton1.SetActive(false);
            acceptButton2.SetActive(false);
            acceptedText2.SetActive(true);
            chat.SetActive(true);
            chatText.text = "The Goblin King can be found in a cave in Goblin Land.";
        }
        else {
            acceptedText1.SetActive(false);
            acceptedText2.SetActive(false);
        }

        if (PlayerInfo.killedGoblinKing == true) {
            completedText2.SetActive(true);
            acceptButton2.SetActive(false);
        }

        //gold
        goldText.text = "Gold: " + Convert.ToString(PlayerInfo.gold);

        //items
        if (PlayerInfo.hasSilverSword == true) {
            buySilverSwordButton.SetActive(false);
        }
        if (PlayerInfo.hasGoldSword == true) {
            buyGoldSwordButton.SetActive(false);
        }
        if (PlayerInfo.hasBow == true) {
            buyBowButton.SetActive(false);
        }
        if (PlayerInfo.hasIronHelmet == true) {
            buyIronHelmetButton.SetActive(false);
        }
        if (PlayerInfo.hasIronArmor == true) {
            buyIronArmorButton.SetActive(false);
        }

        numPotionText.text = "Owned: " + PlayerInfo.healthPotions;
    }

    public void Exit() {
        SceneManager.LoadScene("Village");
    }

    public void AcceptQuest1() {
        if (Quests.activeQuest == false) {
            Quests.goblinsKilled = 0;
            Quests.quest1Accepted = true;
        }
    }

    public void AcceptQuest2() {
        if (Quests.activeQuest == false) {
            Quests.quest2Accepted = true;
        }
    }

    public void BuyPotion() {
        if (PlayerInfo.gold >= 50) {
            PlayerInfo.healthPotions += 1;
            PlayerInfo.gold -= 50;
        }
    }

    public void BuySilverSword() {
        if (PlayerInfo.gold >= 100) {
            PlayerInfo.hasSilverSword = true;
            PlayerInfo.gold -= 100;
        }
    }

    public void BuyGoldSword() {
        if (PlayerInfo.gold >= 150) {
            PlayerInfo.hasGoldSword = true;
            PlayerInfo.gold -= 150;
        }
    }

    public void BuyBow() {
        if (PlayerInfo.gold >= 100) {
            PlayerInfo.hasBow = true;
            PlayerInfo.gold -= 100;
        }
    }

    public void BuyIronHelmet() {
        if (PlayerInfo.gold >= 100) {
            PlayerInfo.hasIronHelmet = true;
            PlayerInfo.gold -= 100;
        }
    }

    public void BuyIronArmor() {
        if (PlayerInfo.gold >= 250) {
            PlayerInfo.hasIronArmor = true;
            PlayerInfo.gold -= 250;
        }
    }
}

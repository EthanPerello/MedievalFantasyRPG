using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Quests : MonoBehaviour
{
    public static bool activeQuest = true;

    public static bool quest0Accepted = true;
    public static bool quest0Completed = false;
    public static bool villagerClicked = false;

    public static bool quest1Accepted = false;
    public static bool quest1Completed = false;
    public static int goblinsKilled = 0;

    public static bool quest2Accepted = false;
    public static bool quest2Completed = false;
    public static bool goblinKingKilled = false;

    private TMPro.TextMeshProUGUI questText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != "MainMenu"){
            questText = GameObject.Find("QuestText").GetComponent<TMPro.TextMeshProUGUI>();
        }

        // quest0
        if (quest0Accepted == true) {
            questText.text = "Quest: Click on a villager to interact";
        }

        if (villagerClicked == true) {
            quest0Completed = true;
        }

        if (quest0Completed == true) {
            questText.text = "Quest: ";
            activeQuest = false;
            quest0Completed = false;
        }

        //quest1
        if (quest1Accepted == true) {
            activeQuest = true;
            questText.text = "Quest: Kill 3 goblins (" + Convert.ToString(goblinsKilled) + "/3)";
        }

        if (goblinsKilled >=3) {
            quest1Completed = true;
        }

        if (quest1Completed == true) {
            questText.text = "Quest: ";
            PlayerInfo.gold += 50;
            goblinsKilled = 0;
            quest1Accepted = false;
            activeQuest = false;
            quest1Completed = false;
        }

        //quest2
        if (quest2Accepted == true) {
            activeQuest = true;
            questText.text = "Quest: Defeat the Goblin King";
        }

        if (goblinKingKilled == true) {
            quest2Completed = true;
        }

        if (quest2Completed == true) {
            questText.text = "Quest: ";
            PlayerInfo.gold += 500;
            goblinKingKilled = false;
            quest2Accepted = false;
            activeQuest = false;
            quest2Completed = false;
        }
    }
}

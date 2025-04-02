using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    public TMPro.TextMeshProUGUI attackText;
    public TMPro.TextMeshProUGUI defenseText;

    private float oldAttack;
    private float newAttack;
    private float oldDefense;
    private float newDefense;

    public static string previousScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        oldAttack = PlayerInfo.baseAttack - 1;
        newAttack = PlayerInfo.baseAttack;
        oldDefense = PlayerInfo.baseDefense - 1;
        newDefense = PlayerInfo.baseDefense;
        attackText.text = "Attack: " + Convert.ToString(oldAttack) + " -> " + Convert.ToString(newAttack);
        defenseText.text = "Defense: " + Convert.ToString(oldDefense) + " -> " + Convert.ToString(newDefense);
    }

    public void Continue() {
        SceneManager.LoadScene(previousScene);
    }
}

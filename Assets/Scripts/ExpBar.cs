using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Image expBar;
    public TMPro.TextMeshProUGUI levelText;
    public TMPro.TextMeshProUGUI currentLevelText;
    public TMPro.TextMeshProUGUI nextLevelText;

    private float currentLevel;
    private float nextLevel;

    // Update is called once per frame
    void Update()
    {
        currentLevel = PlayerInfo.level;
        nextLevel = PlayerInfo.level + 1;
        levelText.text = "Level " + Convert.ToString(currentLevel);
        currentLevelText.text = Convert.ToString(currentLevel);
        nextLevelText.text = Convert.ToString(nextLevel);

        expBar.fillAmount = PlayerInfo.currentExp / PlayerInfo.expToNextLevel;
    }
}

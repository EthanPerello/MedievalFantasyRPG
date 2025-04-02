using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtons : MonoBehaviour
{
    RememberPosition playerPosData;
    
    private void Awake() {
        playerPosData = FindFirstObjectByType<RememberPosition>();
    }

    public void map() {
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("Map");
    }

    public void inventory() {
        playerPosData.PlayerPosSave();
        Inventory.previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Inventory");
    }

    public void quit() {
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        playerPosData.PlayerPosSave();
        SceneManager.LoadScene("MainMenu");
    }

    public void NewGame() {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("CreateCharacter");
    }

    public void LoadGame() {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }
}

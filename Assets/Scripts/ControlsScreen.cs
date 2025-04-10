using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsScreen : MonoBehaviour
{
    // Reference to the controls screen panel
    public GameObject controlsPanel;

    void Start()
    {
        // Ensure the controls panel is initially displayed
        if (controlsPanel != null)
        {
            controlsPanel.SetActive(true);
        }
    }

    // Called when the Continue button is clicked
    public void ContinueToVillage()
    {
        SceneManager.LoadScene("CreateCharacter");
    }
}
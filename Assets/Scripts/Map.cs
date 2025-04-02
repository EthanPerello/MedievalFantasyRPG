using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void homeVillage() {
        SceneManager.LoadScene("Village");
    }

    public void goblinLand() {
        GoblinSpawner.goblins = 0;
        GoblinKing.health = 100;
        SceneManager.LoadScene("GoblinLand");
    }

    public void island() {
        SkeletonSpawner.skeletons = 0;
        SceneManager.LoadScene("Island");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

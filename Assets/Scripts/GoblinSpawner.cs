using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinSpawner : MonoBehaviour
{
    private GameObject goblin;
    private int spawnNum = 5;
    private float yLevel = 22;

    public static int goblins = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        goblin = GameObject.Find("Goblin");
        if (goblins < spawnNum) {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 100), yLevel, Random.Range(0, 100));

            Instantiate(goblin, randomSpawnPosition, Quaternion.identity);

            goblins += 1;
        }
    }
}

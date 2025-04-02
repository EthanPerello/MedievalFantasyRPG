using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonSpawner : MonoBehaviour
{
    public GameObject skeleton;
    private int spawnNum = 5;
    private float yLevel = 22;

    public static int skeletons = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (skeletons < spawnNum) {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 100), yLevel, Random.Range(0, 100));

            Instantiate(skeleton, randomSpawnPosition, Quaternion.identity);

            skeletons += 1;
        }
    }
}

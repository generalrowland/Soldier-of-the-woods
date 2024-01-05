using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int wave;
    public GameObject[] spawnPoints;
    public GameObject pTSD, survivorsGuilt, suicidalDepression, sexualAssault, traumaticBrainInjury, grief, panic, anxiety;


    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        Spawn(12, pTSD);
        wave = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("Enemy"))
        {
            wave++;
            switch (wave)
            {
                case 1:
                    break;
                case 2:
                    Spawn(12, pTSD);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                    default: break;
            }
        }
    }

    void Spawn(int monstersToSpawn, GameObject enemy)
    {
        for(int i = 0; i< monstersToSpawn; i++)
        {
            int j = Random.Range(0, spawnPoints.Length);
            GameObject enemyClone = Instantiate(enemy, spawnPoints[j].transform.position, spawnPoints[j].transform.rotation);
        }
    }
}

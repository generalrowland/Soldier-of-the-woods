using System.Collections;
using System.Collections.Generic;
using TMPro;
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
                    Spawn(12, survivorsGuilt);
                    break;
                case 4:
                    Spawn(12, suicidalDepression);
                    break;
                case 5:
                    Spawn(12, sexualAssault);
                    break;
                case 6:
                    Spawn(12, traumaticBrainInjury);
                    break;
                case 7:
                    Spawn(12, grief);
                    break;
                case 8:
                    Spawn(12, panic);
                    break;
                case 9: 
                    Spawn(12, anxiety);
                    break;
                case 10: 
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

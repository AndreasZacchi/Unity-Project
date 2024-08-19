using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public GameObject enemy;

    List<GameObject> enemies = new();

    int numOfEnemies = 2;

    // Start is called before the first frame update
    void Start()
    {
        //-7.8
        //6.5
        for (int i = 0; i < numOfEnemies; i++) {
            GameObject spawnedEnemy = Instantiate(enemy);
            enemies.Add(spawnedEnemy);
        }
        foreach(GameObject enemy in enemies) {
            Vector3 position = new Vector3(Random.Range(-7.8f, 6.5f), 14f, -0.63f);
            enemy.transform.position = position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

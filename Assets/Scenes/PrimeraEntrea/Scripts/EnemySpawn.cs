using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private EnemyWaypoints[] enemySpawn; 
    [SerializeField] private Transform[] enemyWaiponts;
    [SerializeField] private int amountIntantiate;

    private void Awake()
    {
        for (int i = 0; i < amountIntantiate; i++)
        {
            SpawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemy()
    {
        var l_position = GetRandomEnemy().position;
        var l_chooseEnemy = ChooseEnemy();
        //var l_chooseEnemy = enemySpawn[p_index];
        var l_instan = Instantiate(l_chooseEnemy, l_position, Quaternion.identity);
        l_instan.RecibeWaipont(enemyWaiponts);
    }
    private EnemyWaypoints ChooseEnemy()
    {
        var l_chooseEnemy = Random.Range(0, enemySpawn.Length);
        return enemySpawn[l_chooseEnemy];
    }

    private Transform GetRandomEnemy()
    {
        var l_random = Random.Range(0,enemySpawn.Length);
        return enemyWaiponts[l_random];
    }
}

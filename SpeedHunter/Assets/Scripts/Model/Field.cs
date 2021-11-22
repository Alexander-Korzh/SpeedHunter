using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Field : MonoBehaviour
{

    public UnityEvent IsReady;

    [SerializeField] private int maxCreaturesOnField = 7;
    [SerializeField] private EnemyCreator enemyCreator;
    [SerializeField] private List<GameObject> enemies;


    public void Create()
    {
        for (int number = 0; number < maxCreaturesOnField; number++)
            enemies.Add(
                enemyCreator.CreateEnemy(number));

        IsReady.Invoke();
    }

    public List<GameObject> GetEnemies() => enemies;

}

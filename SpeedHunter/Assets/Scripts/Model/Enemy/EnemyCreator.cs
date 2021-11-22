using System;
using UnityEngine;
using UnityEngine.Events;


public class EnemyCreator : MonoBehaviour
{

    [SerializeField] private EnemyTransform transformCreator;
    [SerializeField] private Prefabs creatures;
    [SerializeField] private Action IfEnemyHited;
    //[SerializeField] private Score gameScore;


    public void Start() =>
        IfEnemyHited = () =>
            Score.AddByHit();

    public GameObject CreateEnemy(int enemyNumber)
    {

        GameObject prefab = creatures.TakeRandom();

        GameObject enemy = Instantiate(prefab, gameObject.transform);

        //TODO Заменить Clicker на интерфейс и протащить дженерики
        enemy.GetComponent<Clicker>().MouseDown += IfEnemyHited;

        enemy.name = prefab.name + " " + enemyNumber;

        transformCreator.CreateRandom(enemy);

        return enemy;
    }
}

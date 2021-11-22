using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyMover : MonoBehaviour
{

    [SerializeField] private Field field;


    public void MoveEnemies<T>() where T : IMove
    {
        foreach (GameObject enemy in field.GetEnemies())
            enemy.GetComponent<T>()
                .MoveThis();
    }
}


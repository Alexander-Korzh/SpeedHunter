using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private EnemyTransform transformCreator;
    [SerializeField] private Action<GameObject> ResetMover;


    public void Start()
    {
        ResetMover = (target) =>
            target.GetComponent<Mover>().
                MoveThis();
    }
        

    public void DoAction(GameObject enemy, Action ChangeScore)
    {

        enemy.GetComponent<MonoBehaviour>().
                StopAllCoroutines();

        transformCreator.CreateRandom(enemy.gameObject);

        ResetMover.Invoke(enemy.gameObject);

        ChangeScore.Invoke();
    }
}

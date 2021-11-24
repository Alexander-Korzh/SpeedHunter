using System;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    #region Fields

    [SerializeField] private EnemyTransform transformCreator;
    [SerializeField] private Action<GameObject> ResetMover;

    #endregion

    #region Methods

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

    #endregion

}

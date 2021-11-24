
using UnityEngine;


public class EnemyMover : MonoBehaviour
{

    #region Fields

    [SerializeField] private Enemies enemiesOnField;
    [SerializeField] private GameLogic enemiesOnFielhd;

    #endregion

    #region Methods

    public void Start()
    {
        enemiesOnField.IsReady.AddListener(() =>
            MoveEnemies<Mover>());

        enemiesOnFielhd.Restart.AddListener(() =>
            StopEnemies<Mover>());
    }
        
    public void MoveEnemies<T>() where T : IMove
    {
        foreach (GameObject enemy in enemiesOnField)
            enemy.GetComponent<T>()
                .MoveThis();
    }

    public void StopEnemies<T>() where T : IMove
    {
        foreach (GameObject enemy in enemiesOnField)
            enemy.GetComponent<T>()
                .StopThis();
    }

    #endregion

}


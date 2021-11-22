using System;
using UnityEngine;
using UnityEngine.Events;

public class GameLogic : MonoBehaviour
{

    public static bool playMode = true;
    public float timeLeft = 30;

    [SerializeField] private EnemyMover enemyMover;
    [SerializeField] private UnityEvent restart;
    [SerializeField] private int speed;

    private void Start()
    {
        speed = 1;
    }

    public void Update()
    {
        if (playMode) timeLeft -= speed * Time.deltaTime;

        if (timeLeft < 0)
        {

            ResetTimer();

            playMode = false;

            restart.Invoke();
        }
    }
    public void ResetTimer() => timeLeft = 30;

    public void MoveEnemies() => enemyMover.MoveEnemies<Mover>();

}

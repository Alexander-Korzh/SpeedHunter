using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Mover : MonoBehaviour, IMove
{

    [SerializeField] private float speed;
    [SerializeField] private int minSpeed = 1;
    [SerializeField] private int maxSpeed = 100;
    [SerializeField] private int direction;


    public void MoveThis()
    {
        SetSpeed();
        SetDiretion();
        StartCoroutine(InfinityMoveCoroutine());    
    }

    public void SetSpeed() => 
        speed = 0.001f * Random.Range(minSpeed, maxSpeed);

    public void SetDiretion() => 
        direction = gameObject.transform.position.x < 0 ? 1 : -1;


    public IEnumerator InfinityMoveCoroutine()
    {
        
        Vector3 step = new Vector3(direction * speed, 0, 0);

        while (true)
        {
            gameObject.transform.position += step;

            yield return null;
        }
    }
}

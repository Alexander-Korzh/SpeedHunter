
using System.Collections;
using UnityEngine;


public class Mover : MonoBehaviour, IMove
{

    #region Fields

    [SerializeField] private float speed;  
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;

    [SerializeField] private int direction;
    
    [SerializeField] private Vector3 step;

    #endregion

    #region Methods

    public void Awake() => step = new Vector3(0, 0, 0);

    public void MoveThis()
    {
        SetSpeed();
        SetDiretion();
        StartCoroutine(InfinityMoveCoroutine());    
    }

    public void StopThis() => StopAllCoroutines();

    public void SetSpeed() => 
        
        speed = 0.2f * Random.Range(minSpeed, maxSpeed);

    public void SetDiretion() => 
        
        direction = gameObject.transform.position.x < 0 ? 1 : -1;

    public IEnumerator InfinityMoveCoroutine()
    {
        step.x = direction * speed * Time.deltaTime;

        while (true)
        {
            gameObject.transform.position += step;

            yield return null;
        }
    }

    #endregion

}

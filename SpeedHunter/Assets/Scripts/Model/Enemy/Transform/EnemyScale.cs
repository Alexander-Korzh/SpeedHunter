
using UnityEngine;


public class EnemyScale : MonoBehaviour
{

    #region Fields

    [SerializeField] private int minScale = 5;
    [SerializeField] private int maxScale = 8;

    #endregion

    #region Methods

    public Vector3 CreateRandom()
    {
        float scale = CreateRandomOneDirection();

        return new Vector3(scale, scale, scale);
    }

    public float CreateRandomOneDirection() =>
        
        0.1f * Random.Range(minScale, maxScale);

    #endregion

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScale : MonoBehaviour
{
    [SerializeField] private int minScale = 5;
    [SerializeField] private int maxScale = 8;


    public Vector3 CreateRandom()
    {
        float scale = CreateRandomOneDirection();

        return new Vector3(scale, scale, scale);
    }

    public float CreateRandomOneDirection() => 0.1f * Random.Range(minScale, maxScale);
}

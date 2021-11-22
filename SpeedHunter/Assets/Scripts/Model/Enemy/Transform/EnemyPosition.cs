using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyPosition : MonoBehaviour
{

    [SerializeField] private float  AbsXBehindTheScreen = 11;
    [SerializeField] private int    AbsMaxY             = 2;
    [SerializeField] private int    ZofEnemy            = 0;


    public Vector3 CreateRandom() => new Vector3(
            CreateX(),
            CreateY(),
            ZofEnemy);

    public float CreateX() => AbsXBehindTheScreen * Mathf.Pow(-1, Random.Range(1, 3));

    public float CreateY() => 2 * Random.Range(- AbsMaxY, AbsMaxY);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTransform : MonoBehaviour
{

    [SerializeField] private EnemyPosition  positionCreator;
    [SerializeField] private EnemyRotation  rotationCreator;
    [SerializeField] private EnemyScale     scaleCreator;


    public void CreateRandom(GameObject target)
    {
        target.transform.position = 
            positionCreator.CreateRandom();

        target.transform.rotation =
            rotationCreator.CreateByPosition(target.transform.position.x);

        target.transform.localScale =
            scaleCreator.CreateRandom();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private int scale;
    [SerializeField] private Action bonusAction;
    [SerializeField] private GameObject bonusPrefab;

    public void Create()
    {
        Instantiate(
            bonusPrefab,
            new Vector3(1, 1, 1),
            Quaternion.identity,
            gameObject.transform);
    }
    public void FillScale() => scale++;
}

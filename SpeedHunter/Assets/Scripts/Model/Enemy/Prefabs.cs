using System;
using System.Collections.Generic;
using UnityEngine;


public class Prefabs : MonoBehaviour
{

    [SerializeField] private List<GameObject> prefabs;


    public GameObject TakeRandom() => 
        prefabs[UnityEngine.Random.Range(0, prefabs.Count)];
    public GameObject this[int index]
    {
        get
        {
            if (index < 0 || index >= prefabs.Count) throw new IndexOutOfRangeException();
            return prefabs[index];
        }
    }
}

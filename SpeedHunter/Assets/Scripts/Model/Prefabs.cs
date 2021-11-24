
using System;
using System.Collections.Generic;
using UnityEngine;



//TODO Логику всего этого класса необходимо переделать на список, мешей а не геймобджектов
public class Prefabs : MonoBehaviour
{

    [SerializeField] protected List<GameObject> prefabs;

    #region Methods

    public virtual GameObject TakeRandom() => 
        
        prefabs[UnityEngine.Random.Range(0, prefabs.Count)];
    
    public virtual GameObject this[int index]
    {
        get
        {
            if (index < 0 || index >= prefabs.Count) throw new IndexOutOfRangeException();
            return prefabs[index];
        }
    }

    #endregion
}

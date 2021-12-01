
using System;
using System.Collections.Generic;
using UnityEngine;



//TODO Logic all of this class should rebuild with using List of Meshes, but not GameObjects
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

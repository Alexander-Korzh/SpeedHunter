
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemies : MonoBehaviour, IEnumerable
{

    public UnityEvent IsReady;

    #region Fields

    [SerializeField] private int maxCreaturesOnField = 7;
    [SerializeField] private EnemyCreator enemyCreator;
    [SerializeField] private List<GameObject> listOfEnemies;

    #endregion

    #region Methods

    public void Create() => StartCoroutine(CreateCotoutine());

    public IEnumerator CreateCotoutine()
    {
        for (int number = 0; number < maxCreaturesOnField; number++)
        {
            listOfEnemies.Add(
                enemyCreator.CreateEnemy(number));
            
            yield return null;
        }
        
        IsReady.Invoke();
    }

    public IEnumerator GetEnumerator() 
    { 
        for (int i = 0; i < listOfEnemies.Count; i++) 
            yield return listOfEnemies[i]; 
    }

    public virtual GameObject this[int index]
    {
        get
        {
            if (index < 0 || index >= listOfEnemies.Count) throw new IndexOutOfRangeException();
            return listOfEnemies[index];
        }
    }

    public void Destroy()
    {
        foreach (GameObject enemy in listOfEnemies) Destroy(enemy);

        listOfEnemies.Clear();
    }

    #endregion

}

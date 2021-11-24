
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GemsPool : Prefabs
{

    #region Methods

    private void Start() => StartCoroutine(Initialize());

    public IEnumerator Initialize()
    {
        List<GameObject> tempPrefabList = new List<GameObject>(prefabs.Count);

        foreach (GameObject prefab in prefabs)
        {
            GameObject gem = Instantiate(prefab, gameObject.transform);

            gem.name = prefab.name;

            gem.SetActive(false);

            tempPrefabList.Add(gem);

            yield return null;
        }

        prefabs.Clear();

        prefabs = tempPrefabList;
    }

    public void InstanceRandom()
    {
        GameObject bonus = TakeRandom();

        bonus.SetActive(true);

        //TODO Переписать диапазон в зависимости от разрешения экрана
        bonus.transform.position =
            new Vector3( 
                Random.Range(-7, 7), 
                Random.Range(-4, 4));
    }

    public void DisableGems() 
    {
        foreach (GameObject prefab in prefabs) prefab.SetActive(false);
    }

    #endregion

}

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Animations;

public class Explode : MonoBehaviour
{

    public Action ExplodeAction;

    [SerializeField] private SkinnedMeshRenderer enemyMesh;
    [SerializeField] private GameObject explodeGameObject;


    //TODO:
    // Смотри TODO ниже
    void Start() => 
        ExplodeAction = () => 
            StartCoroutine(CoroutineActionExplode());


    public IEnumerator CoroutineActionExplode()
    {

        //TODO:
        // Переделать работу с анимацией не через геймобжект, а через аниматор или типа того
        // чтобы была обратная связь черел bool

        explodeGameObject.SetActive(true);

        enemyMesh.enabled = false;

        //Время анимации 0.5 с, берем с запасом на перемещение объекта за экран
        yield return new WaitForSeconds(1f); 

        enemyMesh.enabled = true;

        explodeGameObject.SetActive(false);

    }
}

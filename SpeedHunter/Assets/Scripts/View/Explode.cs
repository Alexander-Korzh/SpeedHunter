using System;
using System.Collections;
using UnityEngine;


public class Explode : MonoBehaviour
{
    #region Fields

    public Action ExplodeAction;

    [SerializeField] private SkinnedMeshRenderer enemyMesh;
    [SerializeField] private GameObject explodeGameObject;

    #endregion

    #region Methods

    //TODO:
    // ������ TODO ����
    void Start() => 
        ExplodeAction = () => 
            StartCoroutine(CoroutineActionExplode());


    public IEnumerator CoroutineActionExplode()
    {

        //TODO:
        // ���������� ������ � ��������� �� ����� ����������, � ����� �������� ��� ���� ����
        // ����� ���� �������� ����� ����� bool

        explodeGameObject.SetActive(true);

        enemyMesh.enabled = false;

        //����� �������� 0.5 �, ����� � ������� �� ����������� ������� �� �����
        yield return new WaitForSeconds(1f); 

        enemyMesh.enabled = true;

        explodeGameObject.SetActive(false);

    }

    #endregion

}

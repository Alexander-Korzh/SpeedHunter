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
}

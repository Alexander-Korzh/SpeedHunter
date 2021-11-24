
using System;
using System.Collections;
using UnityEngine;


public class EnemyClicker : Clicker
{

    #region Fields

    [SerializeField] private Explode explodeInstance;
    [SerializeField] private Respawn respawnEnemy;
    [SerializeField] private Bonus bonusInstance;

    #endregion

    #region Methods

    public void Start()
    {
        
        respawnEnemy = 
            gameObject.transform.root.GetComponent<Respawn>();

        bonusInstance =
            gameObject.transform.root.GetComponent<Bonus>();

        MouseDown += () =>
        {
            bonusInstance.FillScale();

            explodeInstance.ExplodeAction.Invoke();

            StartCoroutine(
                DelayBeforeRespawn(
                    () => respawnEnemy.DoAction(
                            gameObject, () => Score.AddByHit())));
        };

    }

    //TODO:
    // ��� �������� - ������� ��� ���������� �������� � 1 �������
    // � �������� - ����� �� �������� �������� ������
    // ���������, ����� ������ ������ ������ � ���������� � ExplodeAction � ������ ������
    // �������� ����� �� ��������� ��������
    public IEnumerator DelayBeforeRespawn(Action actionAfterDelay)
    {

        yield return new WaitForSeconds(1);

        actionAfterDelay.Invoke();
    }

    #endregion

}


using System;
using System.Collections;
using UnityEngine;


public class EnemyClicker : Clicker
{

    [SerializeField] private Explode explodeInstance;
    [SerializeField] private Respawn respawnEnemy;
    [SerializeField] private Bonus bonusInstance;

 
    public void Start()
    {
        respawnEnemy = 
            gameObject.transform.root.GetComponent<Respawn>();

        bonusInstance =
            gameObject.transform.root.GetComponent<Bonus>();

        MouseDown += () => 
            bonusInstance.FillScale();

        MouseDown += () =>
            explodeInstance.ExplodeAction.Invoke();

        MouseDown += () => 
            StartCoroutine(
                DelayBeforeRespawn(
                    () => respawnEnemy.DoAction(
                            gameObject, () => Score.AddByHit())));
    }

    //TODO:
    // Ёта корутина - костыль дл€ добавлени€ задержки в секунду
    // ј задержка - врем€ на сработку анимации взрыва
    // ѕеределаю, когда познаю логику работы с аниматором в ExplodeAction и выт€ну оттуда bool об окончании анимации
    public IEnumerator DelayBeforeRespawn(Action actionAfterDelay)
    {

        yield return new WaitForSeconds(1);

        actionAfterDelay.Invoke();
    }
}

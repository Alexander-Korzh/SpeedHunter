
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{

    [SerializeField] private Respawn respawnEnemy;


    public void OnTriggerEnter(Collider enemyCollider) => 
        respawnEnemy.DoAction(
            enemyCollider.gameObject, 
            () => Score.DecreaseByMiss() );

}

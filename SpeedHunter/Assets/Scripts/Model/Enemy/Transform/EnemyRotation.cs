
using UnityEngine;


public class EnemyRotation : MonoBehaviour
{
    public Quaternion CreateByPosition(float xPosition) =>
        xPosition < 0 ? new Quaternion(0, 1, 0, 1) : new Quaternion(0, -1, 0, 1);

}

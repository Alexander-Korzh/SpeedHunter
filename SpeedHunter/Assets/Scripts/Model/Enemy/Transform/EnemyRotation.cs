
using UnityEngine;


public class EnemyRotation : MonoBehaviour
{

    #region Fields

    private Quaternion left = new Quaternion (0,  1, 0, 1);
    private Quaternion right= new Quaternion (0, -1, 0, 1);

    #endregion

    #region Methods

    public Quaternion CreateByPosition(float xPosition) =>
        
        xPosition < 0 ? 
            left : 
            right;

    #endregion

}

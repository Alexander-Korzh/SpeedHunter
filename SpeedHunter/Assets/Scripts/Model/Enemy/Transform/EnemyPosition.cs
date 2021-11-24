using UnityEngine;


public class EnemyPosition : MonoBehaviour
{
   
    #region Fields

    //TODO Сделать привязку к размеру экрана
    [SerializeField] private float  AbsXBehindTheScreen = 11;
    [SerializeField] private int    AbsMaxY             = 2;
    [SerializeField] private int    ZofEnemy            = 0;

    #endregion

    #region Methods

    public Vector3 CreateRandom() => 
        
        new Vector3(
            CreateX(),
            CreateY(),
            ZofEnemy);

    public float CreateX() => 
        
        AbsXBehindTheScreen * Mathf.Pow(-1, Random.Range(1, 3));

    public float CreateY() => 
        
        2 * Random.Range(- AbsMaxY, AbsMaxY);

    #endregion

}

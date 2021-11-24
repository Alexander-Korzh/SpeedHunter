
using DG.Tweening;
using UnityEngine;


public class BounceEffect : MonoBehaviour
{

    #region Fields

    [SerializeField] private float endValue;
    [SerializeField] private float duration;

    private Vector3 punch;

    #endregion

    #region Methods

    private void Start() => 
        
        punch = new Vector3(0, endValue, 0);

    public void Create() =>

        transform.DOPunchScale(punch, duration);

    #endregion

}

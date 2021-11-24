
using DG.Tweening;
using UnityEngine;


public class LoadBackground : MonoBehaviour
{
    #region Fields

    [SerializeField] private float depth;
    [SerializeField] private float duration;

    #endregion

    #region Methods

    public void DoAction() =>
        
        gameObject.transform.DOMoveY(0, duration);

    public void SetDefault() =>

        gameObject.transform.DOMoveY(-depth, duration);

    #endregion

}

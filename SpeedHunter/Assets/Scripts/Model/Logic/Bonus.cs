using System;
using UnityEngine;


public class Bonus : MonoBehaviour
{
    public int Count { get; private set; } = 0;

    #region Fields

    public Action countChanged;

    [SerializeField] private GemsPool gems;

    #endregion

    #region Methods

    private void Start() => Count = 0;

    public void FillScale()
    {
        if ( Count < 5) Count++;
        
        else
        {
            Count = 0;
            gems.InstanceRandom();
        }

        countChanged.Invoke();
    }

    public void ResetValue()
    {
        Count = 0;

        countChanged.Invoke();
    }

    #endregion

}

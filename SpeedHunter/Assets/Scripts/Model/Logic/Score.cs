
using System;
using UnityEngine;


//TODO Подкрутить модификаторы
public class Score : MonoBehaviour
{
    public static int DefaultValue { get; private set; } = 10;
    public static int Value { get; private set; } = DefaultValue;

    public static Action ValueChanged;

    #region Methods

    public static void AddByHit()
    {
        Value++;
        
        ValueChanged.Invoke();
    }

    public static void AddByBonus()
    {
        Value += 5;
       
        ValueChanged.Invoke();
    }

    public static void DecreaseByMiss()
    {
        Value--;
       
        ValueChanged.Invoke();
    }

    public static void ResetValue()
    {
        Value = DefaultValue;

        ValueChanged.Invoke();
    }

    #endregion

}

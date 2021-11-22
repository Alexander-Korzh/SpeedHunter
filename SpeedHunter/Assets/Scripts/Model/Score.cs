using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public static int Value { get; private set; } = 10;

    public static Action ValueChanged;


    public static void AddByHit()
    {
        Value++;
        ValueChanged.Invoke();
    }

    public static void AddByBonus()
    {
        Value = Value + 5;
        ValueChanged.Invoke();
    }

    public static void DecreaseByMiss()
    {
        Value--;
        ValueChanged.Invoke();
    }
}

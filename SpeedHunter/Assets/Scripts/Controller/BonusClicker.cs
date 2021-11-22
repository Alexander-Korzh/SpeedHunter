using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BonusClicker : Clicker
{

    public void Start()
    {
        MouseDown += () => Score.AddByBonus();       
    }
}

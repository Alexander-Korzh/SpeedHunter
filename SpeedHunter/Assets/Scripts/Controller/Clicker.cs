
using System;
using UnityEngine;


public class Clicker : MonoBehaviour
{

    public Action MouseDown;

    protected virtual void OnMouseDown() => MouseDown.Invoke();

}

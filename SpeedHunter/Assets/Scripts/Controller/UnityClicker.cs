
using UnityEngine;
using UnityEngine.Events;

public class UnityClicker : MonoBehaviour
{
    [SerializeField] public UnityEvent MouseDown;
    protected virtual void OnMouseDown() => MouseDown.Invoke();
}

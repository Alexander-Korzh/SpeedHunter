
using UnityEngine;
using UnityEngine.UI;


public class TimeLeftSlider : MonoBehaviour
{
    #region Fields

    public Slider timeLeftSlider;

    [SerializeField] private GameLogic gameLogic;

    #endregion

    private void Update() => timeLeftSlider.value = gameLogic.timeLeft;
}

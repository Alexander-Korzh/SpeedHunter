
using UnityEngine;
using UnityEngine.UI;


public class TimeLeftSlider : MonoBehaviour
{
    
    public Slider timeLeftSlider;

    private void Update() => 
        
        timeLeftSlider.value = GameLogic.TimeLeft;
}

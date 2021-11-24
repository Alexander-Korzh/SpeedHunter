
using UnityEngine;
using UnityEngine.UI;

public class BonusSlider : MonoBehaviour
{
    #region Fields

    public Slider bonusSlider;

    [SerializeField] private Bonus bonusInstance;
    [SerializeField] private BounceEffect bounce;

    #endregion

    private void Awake()
    {
        bonusInstance.countChanged += () =>
        {
            bonusSlider.value = bonusInstance.Count;

            bounce.Create();
        };
    }
}


using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{
    #region Fields

    [SerializeField] private float duration;
    [SerializeField] private MaskableGraphic transparency;

    #endregion

    public Tweener ChangeAlfa(float alfa) => transparency.DOFade(alfa, duration);
}

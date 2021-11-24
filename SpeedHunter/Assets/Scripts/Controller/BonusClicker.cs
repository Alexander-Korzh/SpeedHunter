
using UnityEngine;


public class BonusClicker : Clicker
{

    #region Fields

    [SerializeField] private GameObject stars;
    [SerializeField] private ParticleSystem starsParticleSystem;

    #endregion

    #region Methods

    public void Awake()
    {

        stars = GameObject.FindWithTag("Stars");

        starsParticleSystem = stars.GetComponent<ParticleSystem>();

        MouseDown += () =>
        {
            AttachStars();

            starsParticleSystem.Play();

            Score.AddByBonus();

            GameLogic.AddSeconds();

            gameObject.SetActive(false);
        };
    }

    private void AttachStars() => 
        
        stars.transform.position = gameObject.transform.position;

    #endregion

}

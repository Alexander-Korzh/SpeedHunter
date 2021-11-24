
using UnityEngine;
using UnityEngine.Events;


public class GameLogic : MonoBehaviour
{
    public const float SessionTime = 30;
    public bool PlayMode { get; private set; } = true;
    public static float TimeLeft { get; private set; } = SessionTime;

    //TODO Инкапсулировать логику ивента рестарт в отдельный класс.
    // А может, так как сделано сейчас, даже лучше? - разобраться
    public UnityEvent Restart;

    #region Methods

    public void Update()
    {
        if (PlayMode) TimeLeft -= Time.deltaTime;

        if (TimeLeft < 0)
        {
            ResetTimer();

            PlayMode = false;

            Restart.Invoke();
        }
    }

    public static void ResetTimer() => TimeLeft = SessionTime;

    public static void AddSeconds() => TimeLeft += 3;

    public void StartGame()
    {
        PlayMode = true;

        Score.ResetValue();
    }

    #endregion

}

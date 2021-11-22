using System.Text;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCount : MonoBehaviour
{

    [SerializeField] private Text textComponent;
    [SerializeField] private StringBuilder taskTextBuilder;


    void Start()
    {
        taskTextBuilder = new StringBuilder(3);

        Score.ValueChanged += () => UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        taskTextBuilder.Clear();
        taskTextBuilder.Append(
            Score.Value.ToString());

        textComponent.text = taskTextBuilder.ToString();
    }
}

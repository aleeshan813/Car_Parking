using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] TextMeshProUGUI pointstext;

    public void Start()
    {
        Points();
    }

    public void levelSelector()
    {
        SceneManager.LoadScene(1);
    }

    public void Volume()
    {

    }

    public void Points()
    {
        // Get the score from the ScoreManager and display it
        int score = ScoreManager.Instance.GetScore();
        pointstext.text = "Total Points: " + score;
    }
}

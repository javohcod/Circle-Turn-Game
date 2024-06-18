using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void ShopMenu()
    {
        SceneManager.LoadScene(3);
    }
}

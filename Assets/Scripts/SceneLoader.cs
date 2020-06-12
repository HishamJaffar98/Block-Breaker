using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    GameStatus score;
    PauseMenu pause;

    private void Start()
    {
        score = FindObjectOfType<GameStatus>();
        pause = FindObjectOfType<PauseMenu>();
    }

    public void LoadNextScene()
    {
        int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentBuildIndex + 1);
    }

    public void LoadStartScene()
    {

        SceneManager.LoadScene(0);
        score.ResetScore();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

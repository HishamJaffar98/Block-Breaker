using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] public bool isGamePaused = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        myAudio.volume = 0.2f;
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        myAudio.volume = 1f;
        Time.timeScale = 1f;
        isGamePaused = false;
    }
}

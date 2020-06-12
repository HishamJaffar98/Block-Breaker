using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    SceneLoader myScene;
    PauseMenu pause;

    private void Start()
    {
        myScene = FindObjectOfType<SceneLoader>();
        pause = FindObjectOfType<PauseMenu>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pause.isGamePaused == false)
        {
            pause.PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pause.isGamePaused == true)
        {
            pause.ResumeGame();
        }
    }
    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void DestroyBlocks()
    {
        breakableBlocks--;
        if(breakableBlocks==0)
        {
            myScene.LoadNextScene();
        }
    }
}

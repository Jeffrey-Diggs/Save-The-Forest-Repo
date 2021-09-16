using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject howToPlay;

    private void Start()
    {
        if (howToPlay == null)
            return;
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadTitleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadInstructions()
    {
        howToPlay.SetActive(true);
    }

    public void UnLoadInstructions()
    {
        howToPlay.SetActive(false);
    }
}

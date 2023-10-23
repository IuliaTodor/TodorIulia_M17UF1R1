using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadSceneAsync("Scene(0,0)");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

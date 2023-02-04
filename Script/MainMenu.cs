using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // private LevelTimer levelTimer;

    void Start(){
        // levelTimer = LevelTimer.instance;
        // levelTimer.ResetLevelTimer();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewPauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    // Update is called once per frame
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }
}

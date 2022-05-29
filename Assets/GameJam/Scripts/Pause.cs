using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public  bool GamePaused = false;
    public GameObject pauseMenu;

    public AudioSource audio;
    public FollowMouse player;
    public static bool GameWon = false;

    private void Start()
    {
        GamePaused = false;
        GameWon = false;
        pauseMenu.SetActive(false);
     
      
    }

    void Update()
    {
        Debug.Log(Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused == true)
            {
                Resume();
            }
            else
            {
                StopGame();
            }
        }
    }

    private void Resume()
    {
        player.canMove = true;
        pauseMenu.SetActive(false);
        //audio.Play(0);
        Time.timeScale = 1f;
        GamePaused = false;
        Debug.Log("Game resumes");
    }

    private void StopGame()
    {
        player.canMove = false;
        StartCoroutine(SlowDownGame());
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
        GamePaused = true;
        Debug.Log("Game is paused");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame()
    {
        player.canMove = true;
        pauseMenu.SetActive(false);
        //audio.Play(0);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting game....");
    }

    public void RestartGame()
    {
        pauseMenu.SetActive(false);
        Debug.Log("Game restrating...");
        GamePaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void NextLevel()
    {
        Debug.Log("Next Level loading...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(1);
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    IEnumerator SlowDownGame()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(0.5f);
    }
}
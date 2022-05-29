using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Fillbar : MonoBehaviour
{
    public Slider timerBar;
    public float gameTime;
    public float timeLeft;
    public FollowMouse player;
    // Start is called before the first frame update
    void Start()
    {
        
        timeLeft = 0;
        timerBar.value = 0  ;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GameStarted==true)
        {
            if (timeLeft < gameTime)
            {
                timeLeft += Time.deltaTime;
                timerBar.value = timeLeft / gameTime;
            }
            else
            {
                Debug.Log("Ran Out of Fuels");
                Time.timeScale = 0;
                SceneManager.LoadScene("Win");
            }

        }
        
    }
}

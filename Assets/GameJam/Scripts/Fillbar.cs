using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fillbar : MonoBehaviour
{
    public Slider timerBar;
    public float gameTime;
    private float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        
        timeLeft = 0;
        timerBar.value = 0  ;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft < gameTime)
        {
            timeLeft += Time.deltaTime;
            timerBar.value = timeLeft/gameTime;
        }
        else
        {
            Debug.Log("Ran Out of Fuels");
            Time.timeScale = 0;
        }
    }
}

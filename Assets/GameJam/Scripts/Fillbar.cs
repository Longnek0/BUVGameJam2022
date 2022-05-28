using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fillbar : MonoBehaviour
{
    public Image timerBar;
    public float gameTime;
    private float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timerBar= GetComponent<Image>();
        timeLeft = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft >0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / gameTime  ;
        }
        else
        {
            Debug.Log("Ran Out of Fuels");
            Time.timeScale = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 420f;

    [SerializeField] Text CountdownText;

    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print (currentTime);
        CountdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {

            currentTime = 0;
        }
    }
}

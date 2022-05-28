using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_SlowDown : MonoBehaviour
{

    public bool SpaceAlreadyHit;
    public bool Time_Slowed = false;
    public bool Time_Normal = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (Time_Normal)
            {
                MakeTimeSlow();
                StartCoroutine(SlowTimeRange());
            }

            else if(Time_Slowed)
            {
                StartCoroutine(ReturnNormal());
            }

            else
            {
                MakeTimeNormal();
            }
        }

        
    }
    IEnumerator ReturnNormal()
    { 
        if(Time_Normal == false)
        {
            if(SpaceAlreadyHit == true)
            {
            yield return new WaitForSeconds(3.0f);
            Time.timeScale = 1.0f;
            Time_Normal = true;
            }
           else
            {
                Time.timeScale = 1.0f;
            }
        }  
    }

    IEnumerator SlowTimeRange()
    {
        yield return new WaitForSeconds(3.0f);
        Time.timeScale = 1.0f;
        Time_Normal = true; 
    }

    void MakeTimeSlow()
    {
        Time_Normal = false;
        Time.timeScale = 0.5f;
        Time_Slowed = true;
    }

    void MakeTimeNormal()
    {
        Time_Slowed = false;
        Time.timeScale = 1.0f;
        Time_Normal = true;
    }
}

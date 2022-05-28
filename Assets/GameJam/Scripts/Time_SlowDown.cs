using System.Collections;
using UnityEngine;

public class Time_SlowDown : MonoBehaviour
{
    public bool SpaceHit;
    public float timeSinceSlowed = 0.0f;
    public bool Time_Normal;

    private void Start()
    {
        SpaceHit = false;
        Time_Normal = true;
    }

    // Update is called once per frame
    private void Update()
    {
        timeSinceSlowed += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time_Normal == true)
            {
                MakeTimeSlow();
                
            }
            else if (Time_Normal == false)
            {
                MakeTimeNormal();
            }
            
        }
        if(timeSinceSlowed >= 2.0f)
            {
                MakeTimeNormal();
            }
    }

    private IEnumerator CheckForCurrent()
    {
        yield return new WaitForSeconds(3.0f);
        if (Time_Normal == false && SpaceHit == true)
        {
            MakeTimeNormal();
        }
        else
        {
        }
    }

    private void MakeTimeSlow()
    {
       
        Time.timeScale = 0.5f;
        SpaceHit = true;
        Time_Normal = false;  
        timeSinceSlowed = 0.0f;
    }

    private void MakeTimeNormal()
    {
        Time.timeScale = 1.0f;
        Time_Normal = true;
        SpaceHit = false;
      
    }
}
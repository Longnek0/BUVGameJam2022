using System.Collections;
using UnityEngine;

public class Time_SlowDown : MonoBehaviour
{
    public bool SpaceHit;

    public bool Time_Normal;

<<<<<<< Updated upstream
    public bool SpaceAlreadyHit;
    public bool Time_Slowed = false;
    public bool Time_Normal = true;
=======
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        SpaceHit = false;
        Time_Normal = true;
    }

    // Update is called once per frame
    void Update()
    {
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
        StartCoroutine(CheckForCurrent());
    }

    IEnumerator CheckForCurrent()
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
    void MakeTimeSlow()
    {
        Time.timeScale = 0.5f;
        SpaceHit = true;
        Time_Normal = false;
    }

    void MakeTimeNormal()
    {
        Time.timeScale = 1.0f;
        Time_Normal = true;
        SpaceHit = false;
    }
}
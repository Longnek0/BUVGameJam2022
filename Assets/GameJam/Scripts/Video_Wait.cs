using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Video_Wait : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject videoPlayer;
    public bool isPlaying;
    void Start()
    {
        isPlaying = true;  
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(DelayTime());
        }
    }
    IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu");
    }

}

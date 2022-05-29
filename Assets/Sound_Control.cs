using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sound_Control : MonoBehaviour
{
    public AudioClip Background_Sound;
    public AudioClip Radio_Sound;
    public AudioClip Thrust_Sound;
    public AudioClip Idle_Sound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WaitToPLayRadio());
    }

    IEnumerator WaitToPLayRadio()
    {
        yield return new WaitForSeconds(14.0f);
        AudioSource.PlayClipAtPoint(Radio_Sound, this.transform.position);
        AudioSource.PlayClipAtPoint(Idle_Sound, this.transform.position);
        
    }
}
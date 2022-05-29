using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanage : MonoBehaviour
{
    public AudioSource Background_Sound;
    public AudioSource Radio_Sound;
    public AudioSource Thrust_Sound;
    public AudioSource Idle_Sound;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(WaitToPLayRadio());
    }

    IEnumerator WaitToPLayRadio()
    {
        yield return new WaitForSeconds(14.0f);
        Destroy(this.gameObject);

    }
}

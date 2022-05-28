using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder_Ani : MonoBehaviour
{
  
    public GameObject redRocket;
    public GameObject sideRocket_left;
    public GameObject sideRocket_right;
    public Animator ANi;
    public Animator Rocketsides;
    public Animator Rocketsides_1;
   
   
    // Start is called before the first frame update
    void Start()
    {
        redRocket.SetActive(true);
        sideRocket_left.SetActive(true);
        sideRocket_right.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            StartCoroutine(RocketDis());
            
        }
        
    }

    IEnumerator RocketDis()
    {
        Rocketsides_1.SetTrigger("right rocket");
        sideRocket_left.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        Rocketsides.SetTrigger("left rocket");
        sideRocket_right.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        ANi.SetTrigger("rocc");
        redRocket.SetActive(false);
    }

}

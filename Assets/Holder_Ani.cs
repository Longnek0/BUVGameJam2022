using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder_Ani : MonoBehaviour
{
  
    public GameObject redRocket;
    public Animator ANi;
   
   
    // Start is called before the first frame update
    void Start()
    {
        redRocket.SetActive(true);
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            ANi.SetTrigger("rocc");
            redRocket.SetActive(false);
        }
        
    }



}

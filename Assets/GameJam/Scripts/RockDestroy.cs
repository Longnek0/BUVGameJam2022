using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDestroy : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" && this.gameObject.tag != "Potion")
        {
            
            Destroy(this.gameObject);
        }
        
        
    }
}

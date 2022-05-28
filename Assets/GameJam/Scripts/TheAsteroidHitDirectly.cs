using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheAsteroidHitDirectly : MonoBehaviour
{
    public int damage;
    public Rigidbody2D rb;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Des")
        Destroy(this.gameObject);
    }
}

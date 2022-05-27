using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    public Rigidbody2D rb;

    public static int damage;
    public int damageRef;

    void Awake()
    {
        damage = damageRef;
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3 ( 0,-4 * Time.deltaTime, 0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           

            //Destroy (collision.gameObject);
            Destroy (this.gameObject);
        } 
        //Enemy enemy = collision.GetComponent<Enemy>();
    }
    
}

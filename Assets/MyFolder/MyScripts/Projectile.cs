using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject bullet;
    public static int damage;
    public int damageRef;
    public Rigidbody2D rb;

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
        Destroy (gameObject, 4);
        transform.Translate(new Vector3 (-5 * Time.deltaTime, 0, 0));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
           
            //Destroy (collision.gameObject);
            Destroy (this.gameObject);
        } 
        //PlayerController PlayerShip = collision.GetComponent<Player>();
    }
}

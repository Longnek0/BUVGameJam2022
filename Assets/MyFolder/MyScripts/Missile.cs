using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Missile : MonoBehaviour
{
    public Transform target;
    public GameObject explosion;

    public float Speed = 5f;
    public float rotateSpeed = 200f;

    Quaternion rotateToTarget;
    Vector3 direction;

    //private Rigidbody2D rb;

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
        
        target = GameObject.Find("PlayerShip").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction,transform.up).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * Speed;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Instantiate (explosion, transform.position, Quaternion.identity);
        Destroy (this.gameObject);
        if(col.gameObject.tag == "Player")
        {
           

            //Destroy (collision.gameObject);
            Destroy (this.gameObject);
        } 
    }
}

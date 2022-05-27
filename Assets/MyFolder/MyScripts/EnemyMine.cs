using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMine : MonoBehaviour
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
        //rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3 ( 0,-4 * Time.deltaTime, 0));
        Destroy (this.gameObject, 10);
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            //Destroy (coll.gameObject);
            Destroy (this.gameObject);
        }
    }
}

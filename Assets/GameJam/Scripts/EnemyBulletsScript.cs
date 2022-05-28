using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletsScript : MonoBehaviour
{
    int dir = -1;
    public Rigidbody2D rb;
    public int speed;
    public int speedX;
    GameObject player;

    void Awake()
    {
        rb.GetComponent<Rigidbody2D>();
    }

   

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speedX * dir, speed * dir);
        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, 10);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (player.GetComponent<SpaceShip>().rampageMode == false)
            {
                col.gameObject.GetComponent<SpaceShip>().Damage();
                Destroy(gameObject);
            }
            else if (player.GetComponent<SpaceShip>().rampageMode == true)
            {
                Destroy(gameObject);
            }           
        }
        if (col.gameObject.tag == "DeathZone")
        {
            Destroy(gameObject);
        }


    }
}

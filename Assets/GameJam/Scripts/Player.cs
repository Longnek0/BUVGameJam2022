using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    public Text levelUp, maxLevel, livesUp;
    GameObject a, b;

    
    public Rigidbody2D rb;
    public float speed;

    public bool rampageMode = false;
    public AudioClip explode;

    public AudioClip livesUp;
    public AudioClip levelUp;

=======
    public int PlayerHealth = 5;
>>>>>>> 828fd8ccb7d057fb2ddfc5b0394aa8984d309631
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
        if (collision.gameObject.tag == "Asteroid")
        {
            PlayerHealth -= damage;
        }
    }
}

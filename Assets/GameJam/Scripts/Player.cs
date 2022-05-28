using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Text levelUp, maxLevel, livesUp;
    GameObject a, b;

    public int Health = 5;
    public Rigidbody2D rb;
    public float speed;

    public bool rampageMode = false;
    public AudioClip explode;

    public AudioClip livesUp;
    public AudioClip levelUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

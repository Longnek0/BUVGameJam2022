using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthM : MonoBehaviour
{
    Rigidbody2D rb;
    

    public SpriteRenderer originalColorSprite;
    public Color originalC;

    public static int playerHealth = 100;
    Text HP;
    public int enemyDamage;
    //public Animator ani;
    public static bool playerDead = false;
    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<Text>();
        originalColorSprite = this.GetComponent<SpriteRenderer>();

        originalC = originalColorSprite.color;

        rb = GetComponent<Rigidbody2D>();
        //ani = GetComponent<Animator>();
    }
    void Update ()
    {
        HP.text = "HP: " + playerHealth;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "EnemyBullet")
        {
            playerHealth -= enemyDamage; 

            if( playerHealth > 0)
            {
                //ani.SetBool("isAttack", true);
                GetComponent<SpriteRenderer>().color = Color.red;
                StartCoroutine(ColorW()); 

                
            }
            else 
            {
                playerDead = true;
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().enabled = false;
                //Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
            
        }
        if (other.gameObject.tag == "Enemy")
        {
            playerHealth -= enemyDamage; 

            if( playerHealth > 0)
            {
                //ani.SetBool("isAttack", true);
                GetComponent<SpriteRenderer>().color = Color.red;
                StartCoroutine(ColorW()); 

                
            }
            else 
            {
                playerDead = true;
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().enabled = false;
                //Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
            
        }
    }
    void OnColliderStay2D(Collider2D other)
    {
        if(other.tag == "EnemyBullet")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "EnemyBullet")
        {
            //ani.SetBool("isAttack", false);
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    private IEnumerator ColorW()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<SpriteRenderer>().color = originalC;

        

    }
}


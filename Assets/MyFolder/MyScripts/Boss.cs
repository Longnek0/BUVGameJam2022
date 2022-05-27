using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{

    public int enemyHealth;
    public int enemyValue;
    public float aniDelay;

    public Transform target;
    public float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        //ani = GetComponent<Animator>();
    }
    //health
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "PlayerBullet")
        {   
            enemyHealth -= Projectile.damage;
            
            if (enemyHealth <= 0)
            {
                ScoreScript.scoreValue += 100;
                SceneManager.LoadScene(3);
                //ani.SetBool("die", true);
                Debug.Log(enemyValue);
                Destroy(gameObject, aniDelay);
                
            }
    
        }
    }
//
    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        
    }
}

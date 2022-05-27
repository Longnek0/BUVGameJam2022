using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyM : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject enemyFire;
    public GameObject enemyFireClone;

    public int enemyHealth;
    public int enemyValue;
    public float aniDelay;
    

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
                ScoreScript.scoreValue += 40;
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
        transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));

        EnemyShooting();
    }
    void EnemyShooting()
    {
        if (Random.Range (0f, 400f) < 1)
        {
            enemyFireClone = Instantiate(enemyFire,new Vector3(enemy.transform.position.x,enemy.transform.position.y - 2.5f, 2),enemy.transform.rotation) as GameObject;
        }
    }
}

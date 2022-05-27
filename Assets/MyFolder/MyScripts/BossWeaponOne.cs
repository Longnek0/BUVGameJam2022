using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeaponOne : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemyFire;
    public GameObject enemyFireClone;

    
    

    // Start is called before the first frame update
    void Start()
    {
        //ani = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        EnemyShooting();
    }
    void EnemyShooting()
    {
        if (Random.Range (0f, 300f) < 1)
        {
            enemyFireClone = Instantiate(enemyFire,new Vector3(enemy.transform.position.x,enemy.transform.position.y - 0.1f, 2),enemy.transform.rotation) as GameObject;
        }
    }
}
